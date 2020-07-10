using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace InforSignature
{
    public partial class UserSettings : MetroFramework.Forms.MetroForm
    {
        UserSetting m_setting;
        List<string> changeRowList = new List<string>();
        string watermarkPosition;
        int index;

        public UserSettings()
        {
            InitializeComponent();
            listFiliais();
        }

        private void filialPathButton_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = diag.SelectedPath;  //selected folder path
                filialPathTextBox.Text = folder;
            }
        }

        private void AssinaturaPfxPathButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile;
            openFile = new System.Windows.Forms.OpenFileDialog();
            openFile.Filter = "Certificate files *.pfx|*.pfx";
            openFile.Title = "Select a file";
            if (openFile.ShowDialog() != DialogResult.OK)
                return;
            AssinaturaPfxTextBox.Text = openFile.FileName;
        }

        private void WatermarkPathButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile;
            openFile = new System.Windows.Forms.OpenFileDialog();
            openFile.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFile.Title = "Select a file";
            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            WatermarkTextBox.Text = openFile.FileName;
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = checkIfIsEmpty();
                if (check == true)
                {
                    return;
                }

                Load_AppSettings();
                string settings = filialNameTextBox.Text + ";" + filialPathTextBox.Text + ";" + AssinaturaPfxTextBox.Text + ";" + passwordTextBox.Text + ";" + WatermarkTextBox.Text + ";" + watermarkPosition;
                m_setting.filiaisSettings.Add(settings);
                m_setting.Save();
                createDirectory(filialPathTextBox.Text);
                watermarkPosition = null;
                this.Close();
                UserSettings thisForm = new UserSettings();
                thisForm.Show();
                listFiliais();
            }
            catch (Exception ex)
            {
                ErrorLogging.ErrorLog(ex);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = checkIfIsEmpty();
                if (check == true)
                {
                    return;
                }

                Load_AppSettings();
                string settings = filialNameTextBox.Text + ";" + filialPathTextBox.Text + ";" + AssinaturaPfxTextBox.Text + ";" + passwordTextBox.Text + ";" + WatermarkTextBox.Text + ";" + watermarkPosition;
                m_setting.filiaisSettings[index] = settings;
                m_setting.Save();
                createDirectory(filialPathTextBox.Text);
                watermarkPosition = null;
                this.Close();
                UserSettings thisForm = new UserSettings();
                thisForm.Show();
                listFiliais();
            }
            catch (Exception ex)
            {
                ErrorLogging.ErrorLog(ex);
            }
        }

        private void FiliaisGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == FiliaisGridView.Columns["DeletarConfig"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Deletar a Filial?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    m_setting.filiaisSettings.RemoveAt(e.RowIndex);
                    m_setting.Save();
                    watermarkPosition = null;
                    this.Close();
                    UserSettings thisForm = new UserSettings();
                    thisForm.Show();
                    listFiliais();
                }
            }
        }

        private void FiliaisGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                index = FiliaisGridView.SelectedRows[0].Index;
                int columnIndex = 0;

                foreach (DataGridViewColumn column in FiliaisGridView.Columns)
                {
                    string readingRow = FiliaisGridView.Rows[index].Cells[columnIndex].Value.ToString();
                    changeRowList.Add(readingRow);
                    columnIndex++;
                }

                filialNameTextBox.Text = changeRowList[0];
                filialPathTextBox.Text = changeRowList[1];
                AssinaturaPfxTextBox.Text = changeRowList[2];
                passwordTextBox.Text = changeRowList[3];
                WatermarkTextBox.Text = changeRowList[4];
                changeRowList.Clear();
                updateButton.Visible = true;
                updateButton.Text = "Atualizar " + filialNameTextBox.Text;

            }
            catch (Exception ex)
            {
                ErrorLogging.ErrorLog(ex);
            }
        }

        #region //RadioButtons
        private void superiorEsquerdaRadio_CheckedChanged(object sender, EventArgs e)
        {
            watermarkPosition = "superior-esquerda";
        }

        private void superiorRadio_CheckedChanged(object sender, EventArgs e)
        {
            watermarkPosition = "superior";
        }

        private void superiorDireitaRadio_CheckedChanged(object sender, EventArgs e)
        {
            watermarkPosition = "superior-direita";
        }

        private void esquerdaRadio_CheckedChanged(object sender, EventArgs e)
        {
            watermarkPosition = "esquerda";
        }

        private void inferiorEsquerdaRadio_CheckedChanged(object sender, EventArgs e)
        {
            watermarkPosition = "inferior-esquerda";
        }

        private void inferiorRadio_CheckedChanged(object sender, EventArgs e)
        {
            watermarkPosition = "inferior";
        }

        private void inferiorDireitaRadio_CheckedChanged(object sender, EventArgs e)
        {
            watermarkPosition = "inferior-direita";
        }

        private void direitaRadio_CheckedChanged(object sender, EventArgs e)
        {
            watermarkPosition = "direita";
        }
        #endregion

        public bool checkIfIsEmpty()
        {
            if (String.IsNullOrEmpty(filialNameTextBox.Text))
            {
                MessageBox.Show("Insira 1-filial NOME para Continuar");
                return true;
            }
            else if (String.IsNullOrEmpty(filialPathTextBox.Text))
            {
                MessageBox.Show("Insira 1-Filial PASTA para Continuar");
                return true;
            }
            else if (String.IsNullOrEmpty(AssinaturaPfxTextBox.Text))
            {
                MessageBox.Show("Insira 2-Assinatura ASSINATURA para Continuar");
                return true;
            }
            else if (String.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Insira 2-Assinatura SENHA para Continuar");
                return true;
            }
            else if (String.IsNullOrEmpty(WatermarkTextBox.Text))
            {
                MessageBox.Show("Insira 3-Watermark WATERMARK para Continuar");
                return true;
            }
            else if (String.IsNullOrEmpty(watermarkPosition))
            {
                MessageBox.Show("Escolha 3-Watermark POSIÇÂO para Continuar");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void createDirectory(string filialPath)
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

            string watermarkPath = filialPath + "\\1 - Estampar";
            createDiretoryHelper(watermarkPath);

            string signPath = filialPath + "\\2 - Assinar";
            createDiretoryHelper(signPath);

            string completedPath = filialPath + "\\3 - Completo";
            createDiretoryHelper(completedPath);
        }

        private void createDiretoryHelper(string path)
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

        public void listFiliais()
        {
            Load_AppSettings();

            foreach (string filial in m_setting.filiaisSettings)
            {
                try
                {
                    filial.Trim('"');
                    char[] separator = { ';' };
                    String[] values = filial.Split(separator);
                    FiliaisGridView.Rows.Add(values[0], values[1], values[2], values[3], values[4], values[5]);
                }
                catch (Exception ex)
                {
                    ErrorLogging.ErrorLog(ex);
                }
            }
        }

        public void Load_AppSettings()
        {
            try
            {
                m_setting = UserSetting.Load();
                if (m_setting == null)
                    m_setting = new UserSetting();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossivel Carregar AppSettings " + ex.Message, "INFOR CUTTER", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
