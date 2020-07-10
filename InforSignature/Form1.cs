using System;
using System.IO;
using System.Windows.Forms;

namespace InforSignature
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int timeLeft;

        public Form1()
        {
            InitializeComponent();  
        }

        private void debug(string txt)
        {
            DebugBox.AppendText(txt + System.Environment.NewLine);
        }

        private void mainFunctionSignature()
        {
            #region //Carregando UserSetting
            UserSetting userSettingN = new UserSetting();
            try
            {
                userSettingN = UserSetting.Load();
                if (userSettingN == null)
                    userSettingN = new UserSetting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            #endregion

            foreach (string filial in userSettingN.filiaisSettings)
            {
                filial.Trim('"');
                //pega Caminhos dentro do path e cria novos diretorios
                char[] separator = { ';' };
                String[] values = filial.Split(separator);
                string filialName = values[0];
                string path = values[1];

                string watermarkPath = path + "\\1 - Estampar";
                createDiretory(watermarkPath);

                string signPath = path + "\\2 - Assinar";
                createDiretory(signPath);

                string completedPath = path + "\\3 - Completo";
                createDiretory(completedPath);

                string signPfxPath = values[2];
                string password = values[3];
                string watermarkImagePath = values[4];
                string watermarkPosition = values[5];

                debug($"Iniciado ... {filialName}");
                debug("Checando certificado ...");
                Cert myCert = null;
                try
                {
                    myCert = new Cert(signPfxPath, password);
                    debug("Certificado OK");
                }
                catch (Exception ex)
                {
                    debug("Error : Certificado ou Password inválido");
                    debug("Exception : " + ex.ToString());
                    ErrorLogging.ErrorLog(ex);
                    return;
                }

                debug("Inserindo MetaDados ... ");

                //Meta Data
                MetaData MyMD = new MetaData();
                MyMD.Author = "Heineken";
                MyMD.Title = "Heineken do Brasil";
                MyMD.Subject = "Assinatura Digital Heineken";
                MyMD.Keywords = "Heineken";
                MyMD.Creator = filialName;
                MyMD.Producer = "Heineken";

                debug("Assinando ... ");

                try
                {
                    string[] watermarkFiles = Directory.GetFiles(watermarkPath);
                    foreach (string file in watermarkFiles)
                    {
                        string filename = Path.GetFileName(file);
                        PdfWatermark pdfw = new PdfWatermark(file, watermarkImagePath, watermarkPosition, signPath);
                        pdfw.watermarkApply();
                        File.Delete(file);
                    }
                    debug("Assinaturas Aplicadas :)");

                    debug("Deixando Assinaturas Visíveis...");
                    string[] pdftoSignPath = Directory.GetFiles(signPath);
                    foreach (string file in pdftoSignPath)
                    {
                        string filename = Path.GetFileName(file);
                        PDFSigner pdfs = new PDFSigner(file, completedPath + "\\" + filename, myCert, MyMD);
                        pdfs.Sign("Heineken", "Heineken", "Heineken", false);
                        File.Delete(file);
                    }
                    debug("Assinaturas visiveis :)");
                }
                catch(Exception ex)
                {
                    ErrorLogging.ErrorLog(ex);
                }
                
            }

            if (checkBox1.Checked)
            {
                System.Threading.Thread.Sleep(4000);
                timeLeft = 15;
            }
        }

        public void createDiretory(string path)
        {
            try
            {
                if (Directory.Exists(path) == false)
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.ErrorLog(ex);
            }
        }

        private void debugSameLine(string txt)
        {
            DebugBox.ResetText();
            DebugBox.AppendText(txt + " ");
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                debugSameLine($"{timeLeft}");
            }
            else
            {
                mainFunctionSignature();
            }
        }

        private void SignButtonM_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                debug("Timer Habilitado, próximo scan em 15 segundos...");
                timeLeft = 15;
                countdownTimer.Start();
            }
            else
            {
                mainFunctionSignature();
            }
        }

        private void SettingButtonM_Click(object sender, EventArgs e)
        {
            UserSettings configform = new UserSettings();
            configform.ShowDialog();
        }
    }
}