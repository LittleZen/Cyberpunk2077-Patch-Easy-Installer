
namespace CP2077___EasyInstall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMain = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAbout = new MetroFramework.Controls.MetroLink();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSettings = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbVInput = new MetroFramework.Controls.MetroCheckBox();
            this.cbDebug = new MetroFramework.Controls.MetroCheckBox();
            this.cbMemoryPool = new MetroFramework.Controls.MetroCheckBox();
            this.cbSpectre = new MetroFramework.Controls.MetroCheckBox();
            this.cbSMT = new MetroFramework.Controls.MetroCheckBox();
            this.cbAVX = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(22, 64);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(340, 70);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "Select Path To Cyberpunk 2077 Main Directory";
            this.btnMain.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnMain.UseSelectable = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(6, 343);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(152, 15);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Patch Version: 0.7.2 (yamashi)";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(291, 344);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(72, 15);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseSelectable = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSettings);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.cbVInput);
            this.groupBox1.Controls.Add(this.cbDebug);
            this.groupBox1.Controls.Add(this.cbMemoryPool);
            this.groupBox1.Controls.Add(this.cbSpectre);
            this.groupBox1.Controls.Add(this.cbSMT);
            this.groupBox1.Controls.Add(this.cbAVX);
            this.groupBox1.Location = new System.Drawing.Point(24, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 199);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings:";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(64, 159);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(179, 23);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.Text = "Open Json settings";
            this.btnSettings.UseSelectable = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(64, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(71, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(175, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Check the box for activate it:";
            // 
            // cbVInput
            // 
            this.cbVInput.AutoSize = true;
            this.cbVInput.Checked = true;
            this.cbVInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVInput.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbVInput.Location = new System.Drawing.Point(225, 96);
            this.cbVInput.Name = "cbVInput";
            this.cbVInput.Size = new System.Drawing.Size(102, 19);
            this.cbVInput.TabIndex = 11;
            this.cbVInput.Text = "Virtual Input";
            this.cbVInput.UseSelectable = true;
            // 
            // cbDebug
            // 
            this.cbDebug.AutoSize = true;
            this.cbDebug.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbDebug.Location = new System.Drawing.Point(225, 71);
            this.cbDebug.Name = "cbDebug";
            this.cbDebug.Size = new System.Drawing.Size(86, 19);
            this.cbDebug.TabIndex = 10;
            this.cbDebug.Text = "Debugger";
            this.cbDebug.UseSelectable = true;
            // 
            // cbMemoryPool
            // 
            this.cbMemoryPool.AutoSize = true;
            this.cbMemoryPool.Checked = true;
            this.cbMemoryPool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMemoryPool.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbMemoryPool.Location = new System.Drawing.Point(225, 46);
            this.cbMemoryPool.Name = "cbMemoryPool";
            this.cbMemoryPool.Size = new System.Drawing.Size(107, 19);
            this.cbMemoryPool.TabIndex = 9;
            this.cbMemoryPool.Text = "Memory Pool";
            this.cbMemoryPool.UseSelectable = true;
            // 
            // cbSpectre
            // 
            this.cbSpectre.AutoSize = true;
            this.cbSpectre.Checked = true;
            this.cbSpectre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpectre.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbSpectre.Location = new System.Drawing.Point(6, 96);
            this.cbSpectre.Name = "cbSpectre";
            this.cbSpectre.Size = new System.Drawing.Size(70, 19);
            this.cbSpectre.TabIndex = 8;
            this.cbSpectre.Text = "Spectre";
            this.cbSpectre.UseSelectable = true;
            // 
            // cbSMT
            // 
            this.cbSMT.AutoSize = true;
            this.cbSMT.Checked = true;
            this.cbSMT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSMT.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbSMT.Location = new System.Drawing.Point(6, 71);
            this.cbSMT.Name = "cbSMT";
            this.cbSMT.Size = new System.Drawing.Size(52, 19);
            this.cbSMT.TabIndex = 7;
            this.cbSMT.Text = "SMT";
            this.cbSMT.UseSelectable = true;
            // 
            // cbAVX
            // 
            this.cbAVX.AccessibleDescription = "";
            this.cbAVX.AutoSize = true;
            this.cbAVX.Checked = true;
            this.cbAVX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAVX.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbAVX.Location = new System.Drawing.Point(6, 46);
            this.cbAVX.Name = "cbAVX";
            this.cbAVX.Size = new System.Drawing.Size(50, 19);
            this.cbAVX.TabIndex = 6;
            this.cbAVX.Tag = "";
            this.cbAVX.Text = "AVX";
            this.cbAVX.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "CP 2077 - EasyPatcher 2.0";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnMain;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink btnAbout;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnSettings;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox cbVInput;
        private MetroFramework.Controls.MetroCheckBox cbDebug;
        private MetroFramework.Controls.MetroCheckBox cbMemoryPool;
        private MetroFramework.Controls.MetroCheckBox cbSpectre;
        private MetroFramework.Controls.MetroCheckBox cbSMT;
        private MetroFramework.Controls.MetroCheckBox cbAVX;
    }
}

