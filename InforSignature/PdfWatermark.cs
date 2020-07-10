using ImageMagick;
using PdfSharp.Drawing;
using PdfSharp.Pdf.IO;
using System;
using System.Drawing;
using System.IO;
using System.Threading;

namespace InforSignature
{
    class PdfWatermark
    {
        private string pdffile = "";
        private string watermarkPath = "";
        private string watermarkPosition = "";
        private string completedPath = "";

        //método construtor
        public PdfWatermark(string pdfFile, string watermarkPath, string watermarkPosition, string completedPath)
        {
            this.pdffile = pdfFile;
            this.watermarkPath = watermarkPath;
            this.watermarkPosition = watermarkPosition;
            this.completedPath = completedPath;
        }

        //método que aplica a marca d'agua
        public void watermarkApply()
        {
            //essas variaveis são usadas para montar o pdf no final
            PdfSharp.Pdf.PdfDocument pdf = PdfReader.Open(pdffile, PdfDocumentOpenMode.Import); //abre o pdf
            PdfSharp.Pdf.PdfDocument out_pdf = null; //variavel usada pra salvar o pdf

            //variveis que converterá o pdf em jpeg para ser editado
            MagickImageCollection images = new MagickImageCollection();
            MagickReadSettings settings = new MagickReadSettings()
            {
                Density = new Density(300, 300) //dpi do jpeg
            };

            try
            {

                images.Read(pdffile, settings);
                string tmpPath = Path.GetTempPath();
                //INSERINDO MARCA DAGUA
                images[0].Write("temp.jpg");//salva primeira imagem do pdf no pasta repo
                Bitmap page_img = new Bitmap(FromFile("temp.jpg")); //pega imagem repo pra colocar marca d'agua
                Bitmap watermark_img = new Bitmap(FromFile(watermarkPath)); //pega marca d'agua

                //MagickImage Le a imagem que vai receber marca d'agua
                using (MagickImage image = new MagickImage(page_img))
                {
                    //APLICANDO MARCA DAGUA
                    using (MagickImage watermark = new MagickImage(watermark_img)) // Lê a marca dágua que será inserida na imagem           

                    {

                        if (watermarkPosition == "inferior-direita")
                        {
                            image.Composite(watermark, Gravity.Southeast, CompositeOperator.Over);
                        }
                        else if (watermarkPosition == "inferior-esquerda")
                        {
                            image.Composite(watermark, Gravity.Southwest, CompositeOperator.Over);
                        }
                        else if (watermarkPosition == "inferior")
                        {
                            image.Composite(watermark, Gravity.South, CompositeOperator.Over);
                        }
                        else if (watermarkPosition == "superior")
                        {
                            image.Composite(watermark, Gravity.North, CompositeOperator.Over);
                        }
                        else if (watermarkPosition == "superior-direita")
                        {
                            image.Composite(watermark, Gravity.Northeast, CompositeOperator.Over);
                        }
                        else if (watermarkPosition == "superior-esquerda")
                        {
                            image.Composite(watermark, Gravity.Northwest, CompositeOperator.Over);
                        }
                        else if (watermarkPosition == "direita")
                        {
                            image.Composite(watermark, Gravity.East, CompositeOperator.Over);
                        }
                        else if (watermarkPosition == "esquerda")
                        {
                            image.Composite(watermark, Gravity.West, CompositeOperator.Over);
                        }


                        watermark.Evaluate(Channels.Alpha, EvaluateOperator.Divide, 4);
                    }

                    // Salvando o resultado na pasta temporaria
                    image.Write("temp.jpg");
                }

                //SALVANDO COMO PDF
                page_img = new Bitmap(FromFile("temp.jpg")); //Pegando o arquivo na pagina temporaria

                out_pdf = new PdfSharp.Pdf.PdfDocument()
                {
                    Version = pdf.Version
                };

                out_pdf.Info.Title = String.Format("Page {0} of {1}", 0, pdf.Info.Title);
                out_pdf.Info.Creator = pdf.Info.Creator;


                string saida = completedPath + "\\" + Path.GetFileName(pdffile);

                //se signature for verdade, jogar em signature, se não, jogar em indexação
                Add_new_page(page_img, out_pdf);
                out_pdf.Save(saida);
                //esperar ao copiar cada arquivo
                Thread.Sleep(1000);
                out_pdf.Close();
                page_img.Dispose();
                File.Delete(pdffile);
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                ErrorLogging.ErrorLog(ex);
            }
        }


        public static System.Drawing.Image FromFile(string path)
        {
            var bytes = File.ReadAllBytes(path);
            var ms = new MemoryStream(bytes);
            var img = System.Drawing.Image.FromStream(ms);
            return img;
        }

        public void Add_new_page(Bitmap region_img, PdfSharp.Pdf.PdfDocument out_pdf)
        {
            // Adiciona a pagina e salva ela
            MemoryStream strm = new MemoryStream();
            region_img.Save(strm, System.Drawing.Imaging.ImageFormat.Png);
            PdfSharp.Pdf.PdfPage new_page = out_pdf.AddPage();
            using (XImage img = XImage.FromStream(strm))
            {
                // Calcula nova altura para manter a proporção da imagem
                var width = region_img.Width;
                var height = (int)(((double)width / (double)img.PixelWidth) * img.PixelHeight);

                // Alterar o tamanho da pagina PDF para corresponder à imagem
                new_page.Width = width;
                new_page.Height = height;

                XGraphics gfx = XGraphics.FromPdfPage(new_page);
                gfx.DrawImage(img, 0, 0, width, height);
            }
        }
    }
}
