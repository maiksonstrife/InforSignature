namespace InforSignature
{
    partial class UserSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettings));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filialPathButton = new MetroFramework.Controls.MetroButton();
            this.filialNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filialPathTextBox = new System.Windows.Forms.TextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AssinaturaPfxPathButton = new MetroFramework.Controls.MetroButton();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AssinaturaPfxTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.WatermarkPathButton = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.inferiorDireitaRadio = new System.Windows.Forms.RadioButton();
            this.direitaRadio = new System.Windows.Forms.RadioButton();
            this.inferiorRadio = new System.Windows.Forms.RadioButton();
            this.inferiorEsquerdaRadio = new System.Windows.Forms.RadioButton();
            this.esquerdaRadio = new System.Windows.Forms.RadioButton();
            this.superiorDireitaRadio = new System.Windows.Forms.RadioButton();
            this.superiorRadio = new System.Windows.Forms.RadioButton();
            this.superiorEsquerdaRadio = new System.Windows.Forms.RadioButton();
            this.WatermarkTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.FiliaisGridView = new System.Windows.Forms.DataGridView();
            this.Filial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastaFilial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastaAssinatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastaWatermark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosiçãoWatermark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletarConfig = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SaveSettingsButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiliaisGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filialPathButton);
            this.groupBox2.Controls.Add(this.filialNameTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.filialPathTextBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 94);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1- Filial";
            // 
            // filialPathButton
            // 
            this.filialPathButton.Location = new System.Drawing.Point(267, 61);
            this.filialPathButton.Name = "filialPathButton";
            this.filialPathButton.Size = new System.Drawing.Size(75, 20);
            this.filialPathButton.TabIndex = 48;
            this.filialPathButton.Text = "Browse";
            this.filialPathButton.UseSelectable = true;
            this.filialPathButton.Click += new System.EventHandler(this.filialPathButton_Click_1);
            // 
            // filialNameTextBox
            // 
            this.filialNameTextBox.Location = new System.Drawing.Point(53, 28);
            this.filialNameTextBox.Name = "filialNameTextBox";
            this.filialNameTextBox.Size = new System.Drawing.Size(208, 20);
            this.filialNameTextBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome";
            // 
            // filialPathTextBox
            // 
            this.filialPathTextBox.Location = new System.Drawing.Point(53, 61);
            this.filialPathTextBox.Name = "filialPathTextBox";
            this.filialPathTextBox.Size = new System.Drawing.Size(208, 20);
            this.filialPathTextBox.TabIndex = 17;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AssinaturaPfxPathButton);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AssinaturaPfxTextBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(409, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 94);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2- Assinatura";
            // 
            // AssinaturaPfxPathButton
            // 
            this.AssinaturaPfxPathButton.Location = new System.Drawing.Point(288, 25);
            this.AssinaturaPfxPathButton.Name = "AssinaturaPfxPathButton";
            this.AssinaturaPfxPathButton.Size = new System.Drawing.Size(75, 20);
            this.AssinaturaPfxPathButton.TabIndex = 50;
            this.AssinaturaPfxPathButton.Text = "Browse";
            this.AssinaturaPfxPathButton.UseSelectable = true;
            this.AssinaturaPfxPathButton.Click += new System.EventHandler(this.AssinaturaPfxPathButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(75, 57);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(208, 20);
            this.passwordTextBox.TabIndex = 29;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Assinatura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Senha";
            // 
            // AssinaturaPfxTextBox
            // 
            this.AssinaturaPfxTextBox.Location = new System.Drawing.Point(75, 25);
            this.AssinaturaPfxTextBox.Name = "AssinaturaPfxTextBox";
            this.AssinaturaPfxTextBox.Size = new System.Drawing.Size(207, 20);
            this.AssinaturaPfxTextBox.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.WatermarkPathButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.inferiorDireitaRadio);
            this.groupBox3.Controls.Add(this.direitaRadio);
            this.groupBox3.Controls.Add(this.inferiorRadio);
            this.groupBox3.Controls.Add(this.inferiorEsquerdaRadio);
            this.groupBox3.Controls.Add(this.esquerdaRadio);
            this.groupBox3.Controls.Add(this.superiorDireitaRadio);
            this.groupBox3.Controls.Add(this.superiorRadio);
            this.groupBox3.Controls.Add(this.superiorEsquerdaRadio);
            this.groupBox3.Controls.Add(this.WatermarkTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox3.Location = new System.Drawing.Point(12, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 94);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3- Watermark";
            // 
            // WatermarkPathButton
            // 
            this.WatermarkPathButton.Location = new System.Drawing.Point(70, 44);
            this.WatermarkPathButton.Name = "WatermarkPathButton";
            this.WatermarkPathButton.Size = new System.Drawing.Size(75, 20);
            this.WatermarkPathButton.TabIndex = 49;
            this.WatermarkPathButton.Text = "Browse";
            this.WatermarkPathButton.UseSelectable = true;
            this.WatermarkPathButton.Click += new System.EventHandler(this.WatermarkPathButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Posição: ";
            // 
            // inferiorDireitaRadio
            // 
            this.inferiorDireitaRadio.AutoSize = true;
            this.inferiorDireitaRadio.Location = new System.Drawing.Point(607, 63);
            this.inferiorDireitaRadio.Name = "inferiorDireitaRadio";
            this.inferiorDireitaRadio.Size = new System.Drawing.Size(90, 17);
            this.inferiorDireitaRadio.TabIndex = 40;
            this.inferiorDireitaRadio.TabStop = true;
            this.inferiorDireitaRadio.Text = "Inferior Direita";
            this.inferiorDireitaRadio.UseVisualStyleBackColor = true;
            this.inferiorDireitaRadio.CheckedChanged += new System.EventHandler(this.inferiorDireitaRadio_CheckedChanged);
            // 
            // direitaRadio
            // 
            this.direitaRadio.AutoSize = true;
            this.direitaRadio.Location = new System.Drawing.Point(607, 40);
            this.direitaRadio.Name = "direitaRadio";
            this.direitaRadio.Size = new System.Drawing.Size(55, 17);
            this.direitaRadio.TabIndex = 39;
            this.direitaRadio.TabStop = true;
            this.direitaRadio.Text = "Direita";
            this.direitaRadio.UseVisualStyleBackColor = true;
            this.direitaRadio.CheckedChanged += new System.EventHandler(this.direitaRadio_CheckedChanged);
            // 
            // inferiorRadio
            // 
            this.inferiorRadio.AutoSize = true;
            this.inferiorRadio.Location = new System.Drawing.Point(515, 63);
            this.inferiorRadio.Name = "inferiorRadio";
            this.inferiorRadio.Size = new System.Drawing.Size(57, 17);
            this.inferiorRadio.TabIndex = 38;
            this.inferiorRadio.TabStop = true;
            this.inferiorRadio.Text = "Inferior";
            this.inferiorRadio.UseVisualStyleBackColor = true;
            this.inferiorRadio.CheckedChanged += new System.EventHandler(this.inferiorRadio_CheckedChanged);
            // 
            // inferiorEsquerdaRadio
            // 
            this.inferiorEsquerdaRadio.AutoSize = true;
            this.inferiorEsquerdaRadio.Location = new System.Drawing.Point(389, 63);
            this.inferiorEsquerdaRadio.Name = "inferiorEsquerdaRadio";
            this.inferiorEsquerdaRadio.Size = new System.Drawing.Size(105, 17);
            this.inferiorEsquerdaRadio.TabIndex = 37;
            this.inferiorEsquerdaRadio.TabStop = true;
            this.inferiorEsquerdaRadio.Text = "Inferior Esquerda";
            this.inferiorEsquerdaRadio.UseVisualStyleBackColor = true;
            this.inferiorEsquerdaRadio.CheckedChanged += new System.EventHandler(this.inferiorEsquerdaRadio_CheckedChanged);
            // 
            // esquerdaRadio
            // 
            this.esquerdaRadio.AutoSize = true;
            this.esquerdaRadio.Location = new System.Drawing.Point(389, 40);
            this.esquerdaRadio.Name = "esquerdaRadio";
            this.esquerdaRadio.Size = new System.Drawing.Size(70, 17);
            this.esquerdaRadio.TabIndex = 36;
            this.esquerdaRadio.TabStop = true;
            this.esquerdaRadio.Text = "Esquerda";
            this.esquerdaRadio.UseVisualStyleBackColor = true;
            this.esquerdaRadio.CheckedChanged += new System.EventHandler(this.esquerdaRadio_CheckedChanged);
            // 
            // superiorDireitaRadio
            // 
            this.superiorDireitaRadio.AutoSize = true;
            this.superiorDireitaRadio.Location = new System.Drawing.Point(607, 17);
            this.superiorDireitaRadio.Name = "superiorDireitaRadio";
            this.superiorDireitaRadio.Size = new System.Drawing.Size(97, 17);
            this.superiorDireitaRadio.TabIndex = 35;
            this.superiorDireitaRadio.TabStop = true;
            this.superiorDireitaRadio.Text = "Superior Direita";
            this.superiorDireitaRadio.UseVisualStyleBackColor = true;
            this.superiorDireitaRadio.CheckedChanged += new System.EventHandler(this.superiorDireitaRadio_CheckedChanged);
            // 
            // superiorRadio
            // 
            this.superiorRadio.AutoSize = true;
            this.superiorRadio.Location = new System.Drawing.Point(515, 17);
            this.superiorRadio.Name = "superiorRadio";
            this.superiorRadio.Size = new System.Drawing.Size(64, 17);
            this.superiorRadio.TabIndex = 34;
            this.superiorRadio.TabStop = true;
            this.superiorRadio.Text = "Superior";
            this.superiorRadio.UseVisualStyleBackColor = true;
            this.superiorRadio.CheckedChanged += new System.EventHandler(this.superiorRadio_CheckedChanged);
            // 
            // superiorEsquerdaRadio
            // 
            this.superiorEsquerdaRadio.AutoSize = true;
            this.superiorEsquerdaRadio.Location = new System.Drawing.Point(389, 17);
            this.superiorEsquerdaRadio.Name = "superiorEsquerdaRadio";
            this.superiorEsquerdaRadio.Size = new System.Drawing.Size(112, 17);
            this.superiorEsquerdaRadio.TabIndex = 33;
            this.superiorEsquerdaRadio.TabStop = true;
            this.superiorEsquerdaRadio.Text = "Superior Esquerda";
            this.superiorEsquerdaRadio.UseVisualStyleBackColor = true;
            this.superiorEsquerdaRadio.CheckedChanged += new System.EventHandler(this.superiorEsquerdaRadio_CheckedChanged);
            // 
            // WatermarkTextBox
            // 
            this.WatermarkTextBox.Location = new System.Drawing.Point(70, 19);
            this.WatermarkTextBox.Name = "WatermarkTextBox";
            this.WatermarkTextBox.Size = new System.Drawing.Size(243, 20);
            this.WatermarkTextBox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Watermark";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(12, 269);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "Filiais Salvas";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FiliaisGridView
            // 
            this.FiliaisGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FiliaisGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FiliaisGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FiliaisGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FiliaisGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FiliaisGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Filial,
            this.PastaFilial,
            this.PastaAssinatura,
            this.Senha,
            this.PastaWatermark,
            this.PosiçãoWatermark,
            this.DeletarConfig});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FiliaisGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.FiliaisGridView.EnableHeadersVisualStyles = false;
            this.FiliaisGridView.Location = new System.Drawing.Point(12, 297);
            this.FiliaisGridView.Name = "FiliaisGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FiliaisGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FiliaisGridView.Size = new System.Drawing.Size(765, 200);
            this.FiliaisGridView.TabIndex = 43;
            this.FiliaisGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FiliaisGridView_CellClick);
            this.FiliaisGridView.DoubleClick += new System.EventHandler(this.FiliaisGridView_DoubleClick);
            // 
            // Filial
            // 
            this.Filial.Frozen = true;
            this.Filial.HeaderText = "Filial";
            this.Filial.Name = "Filial";
            this.Filial.ReadOnly = true;
            this.Filial.Width = 102;
            // 
            // PastaFilial
            // 
            this.PastaFilial.Frozen = true;
            this.PastaFilial.HeaderText = "PastaFilial";
            this.PastaFilial.Name = "PastaFilial";
            this.PastaFilial.ReadOnly = true;
            this.PastaFilial.Width = 130;
            // 
            // PastaAssinatura
            // 
            this.PastaAssinatura.Frozen = true;
            this.PastaAssinatura.HeaderText = "PastaAssinatura";
            this.PastaAssinatura.Name = "PastaAssinatura";
            this.PastaAssinatura.ReadOnly = true;
            // 
            // Senha
            // 
            this.Senha.Frozen = true;
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            // 
            // PastaWatermark
            // 
            this.PastaWatermark.Frozen = true;
            this.PastaWatermark.HeaderText = "PastaWatermark";
            this.PastaWatermark.Name = "PastaWatermark";
            // 
            // PosiçãoWatermark
            // 
            this.PosiçãoWatermark.Frozen = true;
            this.PosiçãoWatermark.HeaderText = "PosiçãoWatermark";
            this.PosiçãoWatermark.Name = "PosiçãoWatermark";
            this.PosiçãoWatermark.Width = 130;
            // 
            // DeletarConfig
            // 
            this.DeletarConfig.Frozen = true;
            this.DeletarConfig.HeaderText = "Deletar";
            this.DeletarConfig.Name = "DeletarConfig";
            this.DeletarConfig.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeletarConfig.Text = "Delete";
            this.DeletarConfig.UseColumnTextForButtonValue = true;
            this.DeletarConfig.Width = 60;
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(702, 503);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SaveSettingsButton.TabIndex = 46;
            this.SaveSettingsButton.Text = "Save";
            this.SaveSettingsButton.UseSelectable = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(12, 503);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(123, 23);
            this.updateButton.TabIndex = 47;
            this.updateButton.Text = "Atualizar";
            this.updateButton.UseSelectable = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 543);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.FiliaisGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserSettings";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "UserSettings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiliaisGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox filialNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filialPathTextBox;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AssinaturaPfxTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton inferiorDireitaRadio;
        private System.Windows.Forms.RadioButton direitaRadio;
        private System.Windows.Forms.RadioButton inferiorRadio;
        private System.Windows.Forms.RadioButton inferiorEsquerdaRadio;
        private System.Windows.Forms.RadioButton esquerdaRadio;
        private System.Windows.Forms.RadioButton superiorDireitaRadio;
        private System.Windows.Forms.RadioButton superiorRadio;
        private System.Windows.Forms.RadioButton superiorEsquerdaRadio;
        private System.Windows.Forms.TextBox WatermarkTextBox;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView FiliaisGridView;
        private MetroFramework.Controls.MetroButton SaveSettingsButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton filialPathButton;
        private MetroFramework.Controls.MetroButton WatermarkPathButton;
        private MetroFramework.Controls.MetroButton AssinaturaPfxPathButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastaFilial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastaAssinatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastaWatermark;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosiçãoWatermark;
        private System.Windows.Forms.DataGridViewButtonColumn DeletarConfig;
    }
}