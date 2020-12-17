
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
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.cbAntialiasing = new MetroFramework.Controls.MetroCheckBox();
            this.cbSkipStartMenu = new MetroFramework.Controls.MetroCheckBox();
            this.cbRemovePedestrians = new MetroFramework.Controls.MetroCheckBox();
            this.cbAsyncCompute = new MetroFramework.Controls.MetroCheckBox();
            this.btnSettings = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbVInput = new MetroFramework.Controls.MetroCheckBox();
            this.cbDebug = new MetroFramework.Controls.MetroCheckBox();
            this.cbMemoryPool = new MetroFramework.Controls.MetroCheckBox();
            this.cbSpectre = new MetroFramework.Controls.MetroCheckBox();
            this.cbSMT = new MetroFramework.Controls.MetroCheckBox();
            this.cbAVX = new MetroFramework.Controls.MetroCheckBox();
            this.tt_save = new MetroFramework.Components.MetroToolTip();
            this.tt_checkUpdate = new MetroFramework.Components.MetroToolTip();
            this.tt_json = new MetroFramework.Components.MetroToolTip();
            this.tt_selectPath = new MetroFramework.Components.MetroToolTip();
            this.tt_avx = new MetroFramework.Components.MetroToolTip();
            this.tt_smt = new MetroFramework.Components.MetroToolTip();
            this.tt_spectre = new MetroFramework.Components.MetroToolTip();
            this.tt_async = new MetroFramework.Components.MetroToolTip();
            this.tt_skip = new MetroFramework.Components.MetroToolTip();
            this.tt_memory = new MetroFramework.Components.MetroToolTip();
            this.tt_debugger = new MetroFramework.Components.MetroToolTip();
            this.tt_vinput = new MetroFramework.Components.MetroToolTip();
            this.tt_pedestrians = new MetroFramework.Components.MetroToolTip();
            this.tt_aliasing = new MetroFramework.Components.MetroToolTip();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(22, 64);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(390, 70);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "Select Path To Cyberpunk 2077 Main Directory";
            this.btnMain.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tt_selectPath.SetToolTip(this.btnMain, "Select Path to your main CP 2077 Directory");
            this.btnMain.UseSelectable = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(6, 386);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(156, 15);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Patch Version: 0.10.0 (yamashi)";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(347, 386);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(72, 15);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseSelectable = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAntialiasing);
            this.groupBox1.Controls.Add(this.cbSkipStartMenu);
            this.groupBox1.Controls.Add(this.cbRemovePedestrians);
            this.groupBox1.Controls.Add(this.cbAsyncCompute);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.cbVInput);
            this.groupBox1.Controls.Add(this.cbDebug);
            this.groupBox1.Controls.Add(this.cbMemoryPool);
            this.groupBox1.Controls.Add(this.cbSpectre);
            this.groupBox1.Controls.Add(this.cbSMT);
            this.groupBox1.Controls.Add(this.cbAVX);
            this.groupBox1.Location = new System.Drawing.Point(24, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(237, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Check Update";
            this.tt_checkUpdate.SetToolTip(this.btnUpdate, "Download and install the last patch version available");
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbAntialiasing
            // 
            this.cbAntialiasing.AutoSize = true;
            this.cbAntialiasing.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbAntialiasing.Location = new System.Drawing.Point(225, 146);
            this.cbAntialiasing.Name = "cbAntialiasing";
            this.cbAntialiasing.Size = new System.Drawing.Size(143, 19);
            this.cbAntialiasing.TabIndex = 18;
            this.cbAntialiasing.Text = "Disable Antialiasing";
            this.tt_aliasing.SetToolTip(this.cbAntialiasing, "Disables antialiasing, not recommended but you do what you want!");
            this.cbAntialiasing.UseSelectable = true;
            // 
            // cbSkipStartMenu
            // 
            this.cbSkipStartMenu.AutoSize = true;
            this.cbSkipStartMenu.Checked = true;
            this.cbSkipStartMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSkipStartMenu.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbSkipStartMenu.Location = new System.Drawing.Point(6, 146);
            this.cbSkipStartMenu.Name = "cbSkipStartMenu";
            this.cbSkipStartMenu.Size = new System.Drawing.Size(123, 19);
            this.cbSkipStartMenu.TabIndex = 17;
            this.cbSkipStartMenu.Text = "Skip Start Menu";
            this.tt_skip.SetToolTip(this.cbSkipStartMenu, "Skips the menu asking you to press space bar to continue (Breaching...)");
            this.cbSkipStartMenu.UseSelectable = true;
            // 
            // cbRemovePedestrians
            // 
            this.cbRemovePedestrians.AutoSize = true;
            this.cbRemovePedestrians.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbRemovePedestrians.Location = new System.Drawing.Point(225, 121);
            this.cbRemovePedestrians.Name = "cbRemovePedestrians";
            this.cbRemovePedestrians.Size = new System.Drawing.Size(147, 19);
            this.cbRemovePedestrians.TabIndex = 16;
            this.cbRemovePedestrians.Text = "Remove Pedestrians";
            this.tt_pedestrians.SetToolTip(this.cbRemovePedestrians, "Removes most of the pedestrians and traffic");
            this.cbRemovePedestrians.UseSelectable = true;
            // 
            // cbAsyncCompute
            // 
            this.cbAsyncCompute.AutoSize = true;
            this.cbAsyncCompute.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbAsyncCompute.Location = new System.Drawing.Point(6, 121);
            this.cbAsyncCompute.Name = "cbAsyncCompute";
            this.cbAsyncCompute.Size = new System.Drawing.Size(122, 19);
            this.cbAsyncCompute.TabIndex = 15;
            this.cbAsyncCompute.Text = "Async Compute";
            this.tt_async.SetToolTip(this.cbAsyncCompute, "Disables async compute, this can give a boost on older GPUs ( nvidia 10xx series " +
        "for example)");
            this.cbAsyncCompute.UseSelectable = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(22, 357);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(179, 23);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.Text = "Open Json settings";
            this.tt_json.SetToolTip(this.btnSettings, "Open JSON settings, for manual editing");
            this.btnSettings.UseSelectable = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(390, 31);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.tt_save.SetToolTip(this.btnSave, "Save your currently settings");
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(105, 16);
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
            this.tt_vinput.SetToolTip(this.cbVInput, "Enables the use of more gamepads (such as the Steam gamepad)");
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
            this.tt_debugger.SetToolTip(this.cbDebug, "Enables the debug menus in game so you can cheat, investigate...");
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
            this.tt_memory.SetToolTip(this.cbMemoryPool, "Improves memory usage, can improve performance on some configurations.");
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
            this.tt_spectre.SetToolTip(this.cbSpectre, "Removes spectre mitigation to improve performance on all configurations.");
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
            this.tt_smt.SetToolTip(this.cbSMT, "Improves performance on AMD CPUs by enabling all cores.");
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
            this.tt_avx.SetToolTip(this.cbAVX, " Fixes a crash when playing the game with a CPU that does not support AVX");
            this.cbAVX.UseSelectable = true;
            // 
            // tt_save
            // 
            this.tt_save.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_save.StyleManager = null;
            this.tt_save.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tt_checkUpdate
            // 
            this.tt_checkUpdate.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_checkUpdate.StyleManager = null;
            this.tt_checkUpdate.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tt_json
            // 
            this.tt_json.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_json.StyleManager = null;
            this.tt_json.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tt_selectPath
            // 
            this.tt_selectPath.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_selectPath.StyleManager = null;
            this.tt_selectPath.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tt_avx
            // 
            this.tt_avx.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_avx.StyleManager = null;
            this.tt_avx.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tt_smt
            // 
            this.tt_smt.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_smt.StyleManager = null;
            this.tt_smt.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tt_spectre
            // 
            this.tt_spectre.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_spectre.StyleManager = null;
            this.tt_spectre.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tt_async
            // 
            this.tt_async.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_async.StyleManager = null;
            this.tt_async.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tt_skip
            // 
            this.tt_skip.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_skip.StyleManager = null;
            this.tt_skip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tt_memory
            // 
            this.tt_memory.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_memory.StyleManager = null;
            this.tt_memory.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tt_debugger
            // 
            this.tt_debugger.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_debugger.StyleManager = null;
            this.tt_debugger.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tt_vinput
            // 
            this.tt_vinput.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_vinput.StyleManager = null;
            this.tt_vinput.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tt_pedestrians
            // 
            this.tt_pedestrians.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_pedestrians.StyleManager = null;
            this.tt_pedestrians.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tt_aliasing
            // 
            this.tt_aliasing.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_aliasing.StyleManager = null;
            this.tt_aliasing.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 404);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "CP 2077 - EasyPatcher | v2.2";
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
        private MetroFramework.Controls.MetroCheckBox cbSkipStartMenu;
        private MetroFramework.Controls.MetroCheckBox cbRemovePedestrians;
        private MetroFramework.Controls.MetroCheckBox cbAsyncCompute;
        private MetroFramework.Controls.MetroCheckBox cbAntialiasing;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Components.MetroToolTip tt_save;
        private MetroFramework.Components.MetroToolTip tt_checkUpdate;
        private MetroFramework.Components.MetroToolTip tt_json;
        private MetroFramework.Components.MetroToolTip tt_selectPath;
        private MetroFramework.Components.MetroToolTip tt_avx;
        private MetroFramework.Components.MetroToolTip tt_async;
        private MetroFramework.Components.MetroToolTip tt_spectre;
        private MetroFramework.Components.MetroToolTip tt_smt;
        private MetroFramework.Components.MetroToolTip tt_skip;
        private MetroFramework.Components.MetroToolTip tt_memory;
        private MetroFramework.Components.MetroToolTip tt_debugger;
        private MetroFramework.Components.MetroToolTip tt_vinput;
        private MetroFramework.Components.MetroToolTip tt_pedestrians;
        private MetroFramework.Components.MetroToolTip tt_aliasing;
    }
}

