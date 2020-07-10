namespace InforSignature
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DebugBox = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.SignButtonM = new MetroFramework.Controls.MetroButton();
            this.SettingButtonM = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkBox1.Location = new System.Drawing.Point(159, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Habilitar Timer";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DebugBox
            // 
            this.DebugBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.DebugBox.CustomButton.Image = null;
            this.DebugBox.CustomButton.Location = new System.Drawing.Point(354, 2);
            this.DebugBox.CustomButton.Name = "";
            this.DebugBox.CustomButton.Size = new System.Drawing.Size(403, 403);
            this.DebugBox.CustomButton.Style = MetroFramework.MetroColorStyle.Red;
            this.DebugBox.CustomButton.TabIndex = 1;
            this.DebugBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DebugBox.CustomButton.UseSelectable = true;
            this.DebugBox.CustomButton.Visible = false;
            this.DebugBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DebugBox.Lines = new string[0];
            this.DebugBox.Location = new System.Drawing.Point(14, 102);
            this.DebugBox.MaxLength = 32767;
            this.DebugBox.Multiline = true;
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.PasswordChar = '\0';
            this.DebugBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DebugBox.SelectedText = "";
            this.DebugBox.SelectionLength = 0;
            this.DebugBox.SelectionStart = 0;
            this.DebugBox.ShortcutsEnabled = true;
            this.DebugBox.Size = new System.Drawing.Size(760, 408);
            this.DebugBox.TabIndex = 32;
            this.DebugBox.UseSelectable = true;
            this.DebugBox.UseStyleColors = true;
            this.DebugBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DebugBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SignButtonM
            // 
            this.SignButtonM.Location = new System.Drawing.Point(14, 76);
            this.SignButtonM.Name = "SignButtonM";
            this.SignButtonM.Size = new System.Drawing.Size(109, 23);
            this.SignButtonM.TabIndex = 33;
            this.SignButtonM.Text = "Assinar";
            this.SignButtonM.UseSelectable = true;
            this.SignButtonM.Click += new System.EventHandler(this.SignButtonM_Click);
            // 
            // SettingButtonM
            // 
            this.SettingButtonM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingButtonM.Location = new System.Drawing.Point(699, 73);
            this.SettingButtonM.Name = "SettingButtonM";
            this.SettingButtonM.Size = new System.Drawing.Size(75, 23);
            this.SettingButtonM.TabIndex = 34;
            this.SettingButtonM.Text = "Settings";
            this.SettingButtonM.UseSelectable = true;
            this.SettingButtonM.Click += new System.EventHandler(this.SettingButtonM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 533);
            this.Controls.Add(this.SettingButtonM);
            this.Controls.Add(this.SignButtonM);
            this.Controls.Add(this.DebugBox);
            this.Controls.Add(this.checkBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 250);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "InforSignature";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.CheckBox checkBox1;
        private MetroFramework.Controls.MetroTextBox DebugBox;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton SignButtonM;
        private MetroFramework.Controls.MetroButton SettingButtonM;
    }
}

