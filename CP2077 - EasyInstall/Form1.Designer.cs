
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
            this.btn_main = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cb_vinput = new MetroFramework.Controls.MetroCheckBox();
            this.cb_debug = new MetroFramework.Controls.MetroCheckBox();
            this.cb_memory = new MetroFramework.Controls.MetroCheckBox();
            this.cb_spectre = new MetroFramework.Controls.MetroCheckBox();
            this.cb_smt = new MetroFramework.Controls.MetroCheckBox();
            this.cb_avx = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_main
            // 
            this.btn_main.Location = new System.Drawing.Point(22, 64);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(340, 70);
            this.btn_main.TabIndex = 0;
            this.btn_main.Text = "Select Path To Cyberpunk 2077 Main Directory";
            this.btn_main.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_main.UseSelectable = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(6, 423);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(152, 15);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Patch Version: 0.7.2 (yamashi)";
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(291, 424);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(72, 15);
            this.metroLink1.TabIndex = 2;
            this.metroLink1.Text = "About";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.cb_vinput);
            this.groupBox1.Controls.Add(this.cb_debug);
            this.groupBox1.Controls.Add(this.cb_memory);
            this.groupBox1.Controls.Add(this.cb_spectre);
            this.groupBox1.Controls.Add(this.cb_smt);
            this.groupBox1.Controls.Add(this.cb_avx);
            this.groupBox1.Location = new System.Drawing.Point(24, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 199);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings:";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(64, 159);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(179, 23);
            this.metroButton2.TabIndex = 14;
            this.metroButton2.Text = "Open Json settings";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(64, 130);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(179, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            // cb_vinput
            // 
            this.cb_vinput.AutoSize = true;
            this.cb_vinput.Checked = true;
            this.cb_vinput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_vinput.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cb_vinput.Location = new System.Drawing.Point(225, 96);
            this.cb_vinput.Name = "cb_vinput";
            this.cb_vinput.Size = new System.Drawing.Size(102, 19);
            this.cb_vinput.TabIndex = 11;
            this.cb_vinput.Text = "Virtual Input";
            this.cb_vinput.UseSelectable = true;
            // 
            // cb_debug
            // 
            this.cb_debug.AutoSize = true;
            this.cb_debug.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cb_debug.Location = new System.Drawing.Point(225, 71);
            this.cb_debug.Name = "cb_debug";
            this.cb_debug.Size = new System.Drawing.Size(86, 19);
            this.cb_debug.TabIndex = 10;
            this.cb_debug.Text = "Debugger";
            this.cb_debug.UseSelectable = true;
            // 
            // cb_memory
            // 
            this.cb_memory.AutoSize = true;
            this.cb_memory.Checked = true;
            this.cb_memory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_memory.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cb_memory.Location = new System.Drawing.Point(225, 46);
            this.cb_memory.Name = "cb_memory";
            this.cb_memory.Size = new System.Drawing.Size(107, 19);
            this.cb_memory.TabIndex = 9;
            this.cb_memory.Text = "Memory Pool";
            this.cb_memory.UseSelectable = true;
            // 
            // cb_spectre
            // 
            this.cb_spectre.AutoSize = true;
            this.cb_spectre.Checked = true;
            this.cb_spectre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_spectre.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cb_spectre.Location = new System.Drawing.Point(6, 96);
            this.cb_spectre.Name = "cb_spectre";
            this.cb_spectre.Size = new System.Drawing.Size(70, 19);
            this.cb_spectre.TabIndex = 8;
            this.cb_spectre.Text = "Spectre";
            this.cb_spectre.UseSelectable = true;
            // 
            // cb_smt
            // 
            this.cb_smt.AutoSize = true;
            this.cb_smt.Checked = true;
            this.cb_smt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_smt.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cb_smt.Location = new System.Drawing.Point(6, 71);
            this.cb_smt.Name = "cb_smt";
            this.cb_smt.Size = new System.Drawing.Size(52, 19);
            this.cb_smt.TabIndex = 7;
            this.cb_smt.Text = "SMT";
            this.cb_smt.UseSelectable = true;
            // 
            // cb_avx
            // 
            this.cb_avx.AccessibleDescription = "";
            this.cb_avx.AutoSize = true;
            this.cb_avx.Checked = true;
            this.cb_avx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_avx.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cb_avx.Location = new System.Drawing.Point(6, 46);
            this.cb_avx.Name = "cb_avx";
            this.cb_avx.Size = new System.Drawing.Size(50, 19);
            this.cb_avx.TabIndex = 6;
            this.cb_avx.Tag = "";
            this.cb_avx.Text = "AVX";
            this.cb_avx.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(22, 145);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(160, 70);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Find Steam Path";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(203, 145);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(160, 70);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "Find GOG Path";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 442);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
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

        private MetroFramework.Controls.MetroButton btn_main;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btn_save;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox cb_vinput;
        private MetroFramework.Controls.MetroCheckBox cb_debug;
        private MetroFramework.Controls.MetroCheckBox cb_memory;
        private MetroFramework.Controls.MetroCheckBox cb_spectre;
        private MetroFramework.Controls.MetroCheckBox cb_smt;
        private MetroFramework.Controls.MetroCheckBox cb_avx;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}

