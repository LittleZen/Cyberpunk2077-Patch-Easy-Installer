
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
            this.btnAbout = new MetroFramework.Controls.MetroLink();
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            this.cbConsole = new MetroFramework.Controls.MetroCheckBox();
            this.cbAntialiasing = new MetroFramework.Controls.MetroCheckBox();
            this.cbSkipStartMenu = new MetroFramework.Controls.MetroCheckBox();
            this.cbRemovePedestrians = new MetroFramework.Controls.MetroCheckBox();
            this.cbAsyncCompute = new MetroFramework.Controls.MetroCheckBox();
            this.lblSettingsText = new MetroFramework.Controls.MetroLabel();
            this.cbVInput = new MetroFramework.Controls.MetroCheckBox();
            this.cbDebug = new MetroFramework.Controls.MetroCheckBox();
            this.cbMemoryPool = new MetroFramework.Controls.MetroCheckBox();
            this.cbSpectre = new MetroFramework.Controls.MetroCheckBox();
            this.cbSMT = new MetroFramework.Controls.MetroCheckBox();
            this.cbAVX = new MetroFramework.Controls.MetroCheckBox();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnSettings = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
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
            this.btnLogs = new MetroFramework.Controls.MetroButton();
            this.gbxMemPool = new System.Windows.Forms.GroupBox();
            this.numGpuMem = new System.Windows.Forms.NumericUpDown();
            this.numCpuMem = new System.Windows.Forms.NumericUpDown();
            this.lblGpuMem = new MetroFramework.Controls.MetroLabel();
            this.lblCpuMem = new MetroFramework.Controls.MetroLabel();
            this.btnUninstall = new MetroFramework.Controls.MetroButton();
            this.btnFindGoG = new MetroFramework.Controls.MetroButton();
            this.btnFindSteam = new MetroFramework.Controls.MetroButton();
            this.tt_steam = new MetroFramework.Components.MetroToolTip();
            this.tt_gog = new MetroFramework.Components.MetroToolTip();
            this.ttEnableConsole = new MetroFramework.Components.MetroToolTip();
            this.gbxSettings.SuspendLayout();
            this.gbxMemPool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGpuMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCpuMem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(22, 64);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(390, 30);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "Manually Select Path to Cyberpunk 2077 Main Directory";
            this.btnMain.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tt_selectPath.SetToolTip(this.btnMain, "Choose this option if GOG/Steam Automatic Path Finder doesn\'t work (or if you hav" +
        "e EpicGames Client)");
            this.btnMain.UseSelectable = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(180, 557);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(72, 15);
            this.btnAbout.TabIndex = 25;
            this.btnAbout.Text = "About";
            this.btnAbout.UseSelectable = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // gbxSettings
            // 
            this.gbxSettings.Controls.Add(this.cbConsole);
            this.gbxSettings.Controls.Add(this.cbAntialiasing);
            this.gbxSettings.Controls.Add(this.cbSkipStartMenu);
            this.gbxSettings.Controls.Add(this.cbRemovePedestrians);
            this.gbxSettings.Controls.Add(this.cbAsyncCompute);
            this.gbxSettings.Controls.Add(this.lblSettingsText);
            this.gbxSettings.Controls.Add(this.cbVInput);
            this.gbxSettings.Controls.Add(this.cbDebug);
            this.gbxSettings.Controls.Add(this.cbMemoryPool);
            this.gbxSettings.Controls.Add(this.cbSpectre);
            this.gbxSettings.Controls.Add(this.cbSMT);
            this.gbxSettings.Controls.Add(this.cbAVX);
            this.gbxSettings.Location = new System.Drawing.Point(24, 141);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(388, 213);
            this.gbxSettings.TabIndex = 3;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Settings:";
            // 
            // cbConsole
            // 
            this.cbConsole.AutoSize = true;
            this.cbConsole.Checked = true;
            this.cbConsole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbConsole.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbConsole.Location = new System.Drawing.Point(6, 171);
            this.cbConsole.Name = "cbConsole";
            this.cbConsole.Size = new System.Drawing.Size(118, 19);
            this.cbConsole.TabIndex = 15;
            this.cbConsole.Text = "Enable Console";
            this.ttEnableConsole.SetToolTip(this.cbConsole, "Adds an overlay to draw whatever UI you want on top of the game.\nPress the \'End\' " +
        "key to toggle the console");
            this.cbConsole.UseSelectable = true;
            // 
            // cbAntialiasing
            // 
            this.cbAntialiasing.AutoSize = true;
            this.cbAntialiasing.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbAntialiasing.Location = new System.Drawing.Point(225, 96);
            this.cbAntialiasing.Name = "cbAntialiasing";
            this.cbAntialiasing.Size = new System.Drawing.Size(143, 19);
            this.cbAntialiasing.TabIndex = 10;
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
            this.cbSkipStartMenu.TabIndex = 13;
            this.cbSkipStartMenu.Text = "Skip Start Menu";
            this.tt_skip.SetToolTip(this.cbSkipStartMenu, "Skips the menu asking you to press space bar to continue (Breaching...)");
            this.cbSkipStartMenu.UseSelectable = true;
            // 
            // cbRemovePedestrians
            // 
            this.cbRemovePedestrians.AutoSize = true;
            this.cbRemovePedestrians.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbRemovePedestrians.Location = new System.Drawing.Point(225, 146);
            this.cbRemovePedestrians.Name = "cbRemovePedestrians";
            this.cbRemovePedestrians.Size = new System.Drawing.Size(147, 19);
            this.cbRemovePedestrians.TabIndex = 14;
            this.cbRemovePedestrians.Text = "Remove Pedestrians";
            this.tt_pedestrians.SetToolTip(this.cbRemovePedestrians, "Removes most of the pedestrians and traffic");
            this.cbRemovePedestrians.UseSelectable = true;
            // 
            // cbAsyncCompute
            // 
            this.cbAsyncCompute.AutoSize = true;
            this.cbAsyncCompute.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbAsyncCompute.Location = new System.Drawing.Point(225, 71);
            this.cbAsyncCompute.Name = "cbAsyncCompute";
            this.cbAsyncCompute.Size = new System.Drawing.Size(122, 19);
            this.cbAsyncCompute.TabIndex = 8;
            this.cbAsyncCompute.Text = "Async Compute";
            this.tt_async.SetToolTip(this.cbAsyncCompute, "Disables async compute, this can give a boost on older GPUs ( nvidia 10xx series " +
        "for example)");
            this.cbAsyncCompute.UseSelectable = true;
            // 
            // lblSettingsText
            // 
            this.lblSettingsText.AutoSize = true;
            this.lblSettingsText.Location = new System.Drawing.Point(105, 16);
            this.lblSettingsText.Name = "lblSettingsText";
            this.lblSettingsText.Size = new System.Drawing.Size(175, 19);
            this.lblSettingsText.TabIndex = 12;
            this.lblSettingsText.Text = "Check the box for activate it:";
            // 
            // cbVInput
            // 
            this.cbVInput.AutoSize = true;
            this.cbVInput.Checked = true;
            this.cbVInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVInput.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbVInput.Location = new System.Drawing.Point(6, 121);
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
            this.cbDebug.Location = new System.Drawing.Point(225, 121);
            this.cbDebug.Name = "cbDebug";
            this.cbDebug.Size = new System.Drawing.Size(86, 19);
            this.cbDebug.TabIndex = 12;
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
            this.cbMemoryPool.TabIndex = 6;
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
            this.cbSpectre.TabIndex = 9;
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
            this.cbAVX.TabIndex = 5;
            this.cbAVX.Tag = "";
            this.cbAVX.Text = "AVX";
            this.tt_avx.SetToolTip(this.cbAVX, " Fixes a crash when playing the game with a CPU that does not support AVX");
            this.cbAVX.UseSelectable = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(22, 524);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Check For &Updates";
            this.tt_checkUpdate.SetToolTip(this.btnUpdate, "Download and install the last patch version available");
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(22, 487);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(390, 31);
            this.btnSettings.TabIndex = 22;
            this.btnSettings.Text = "&Open JSON Settings";
            this.tt_json.SetToolTip(this.btnSettings, "Open JSON settings, for manual editing");
            this.btnSettings.UseSelectable = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(390, 31);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save Settings";
            this.tt_save.SetToolTip(this.btnSave, "Save your currently settings");
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // btnLogs
            // 
            this.btnLogs.Location = new System.Drawing.Point(22, 450);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(390, 31);
            this.btnLogs.TabIndex = 21;
            this.btnLogs.Text = "&Open Patch Logs";
            this.btnLogs.UseSelectable = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // gbxMemPool
            // 
            this.gbxMemPool.Controls.Add(this.numGpuMem);
            this.gbxMemPool.Controls.Add(this.numCpuMem);
            this.gbxMemPool.Controls.Add(this.lblGpuMem);
            this.gbxMemPool.Controls.Add(this.lblCpuMem);
            this.gbxMemPool.Location = new System.Drawing.Point(24, 360);
            this.gbxMemPool.Name = "gbxMemPool";
            this.gbxMemPool.Size = new System.Drawing.Size(388, 47);
            this.gbxMemPool.TabIndex = 15;
            this.gbxMemPool.TabStop = false;
            this.gbxMemPool.Text = "Memory Pool:";
            // 
            // numGpuMem
            // 
            this.numGpuMem.DecimalPlaces = 2;
            this.numGpuMem.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numGpuMem.Location = new System.Drawing.Point(341, 19);
            this.numGpuMem.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGpuMem.Name = "numGpuMem";
            this.numGpuMem.Size = new System.Drawing.Size(45, 20);
            this.numGpuMem.TabIndex = 19;
            this.numGpuMem.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // numCpuMem
            // 
            this.numCpuMem.DecimalPlaces = 2;
            this.numCpuMem.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numCpuMem.Location = new System.Drawing.Point(129, 19);
            this.numCpuMem.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCpuMem.Name = "numCpuMem";
            this.numCpuMem.Size = new System.Drawing.Size(45, 20);
            this.numCpuMem.TabIndex = 17;
            this.numCpuMem.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // lblGpuMem
            // 
            this.lblGpuMem.AutoSize = true;
            this.lblGpuMem.Location = new System.Drawing.Point(220, 20);
            this.lblGpuMem.Name = "lblGpuMem";
            this.lblGpuMem.Size = new System.Drawing.Size(123, 19);
            this.lblGpuMem.TabIndex = 18;
            this.lblGpuMem.Text = "GPU Memory Pool:";
            // 
            // lblCpuMem
            // 
            this.lblCpuMem.AutoSize = true;
            this.lblCpuMem.Location = new System.Drawing.Point(6, 20);
            this.lblCpuMem.Name = "lblCpuMem";
            this.lblCpuMem.Size = new System.Drawing.Size(123, 19);
            this.lblCpuMem.TabIndex = 16;
            this.lblCpuMem.Text = "CPU Memory Pool:";
            // 
            // btnUninstall
            // 
            this.btnUninstall.Location = new System.Drawing.Point(237, 524);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(175, 23);
            this.btnUninstall.TabIndex = 24;
            this.btnUninstall.Text = "&Uninstall";
            this.btnUninstall.UseSelectable = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnFindGoG
            // 
            this.btnFindGoG.Location = new System.Drawing.Point(232, 105);
            this.btnFindGoG.Name = "btnFindGoG";
            this.btnFindGoG.Size = new System.Drawing.Size(180, 30);
            this.btnFindGoG.TabIndex = 2;
            this.btnFindGoG.Text = "Automatic Detect GOG Path";
            this.btnFindGoG.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tt_gog.SetToolTip(this.btnFindGoG, "Automatically Detect GOG Path");
            this.btnFindGoG.UseSelectable = true;
            this.btnFindGoG.Click += new System.EventHandler(this.btnFindGoG_Click);
            // 
            // btnFindSteam
            // 
            this.btnFindSteam.Location = new System.Drawing.Point(22, 105);
            this.btnFindSteam.Name = "btnFindSteam";
            this.btnFindSteam.Size = new System.Drawing.Size(180, 30);
            this.btnFindSteam.TabIndex = 1;
            this.btnFindSteam.Text = "Automatic Detect Steam Path";
            this.btnFindSteam.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tt_steam.SetToolTip(this.btnFindSteam, "Automatically Detect Steam Path");
            this.btnFindSteam.UseSelectable = true;
            this.btnFindSteam.Click += new System.EventHandler(this.btnFindSteam_Click);
            // 
            // tt_steam
            // 
            this.tt_steam.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_steam.StyleManager = null;
            this.tt_steam.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tt_gog
            // 
            this.tt_gog.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt_gog.StyleManager = null;
            this.tt_gog.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ttEnableConsole
            // 
            this.ttEnableConsole.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttEnableConsole.StyleManager = null;
            this.ttEnableConsole.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 589);
            this.Controls.Add(this.btnFindGoG);
            this.Controls.Add(this.btnFindSteam);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.gbxMemPool);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbxSettings);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "CP 2077 - EasyPatcher | v2.5";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSettings.ResumeLayout(false);
            this.gbxSettings.PerformLayout();
            this.gbxMemPool.ResumeLayout(false);
            this.gbxMemPool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGpuMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCpuMem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnMain;
        private MetroFramework.Controls.MetroLink btnAbout;
        private System.Windows.Forms.GroupBox gbxSettings;
        private MetroFramework.Controls.MetroButton btnSettings;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel lblSettingsText;
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
        private MetroFramework.Controls.MetroButton btnLogs;
        private System.Windows.Forms.GroupBox gbxMemPool;
        private MetroFramework.Controls.MetroLabel lblCpuMem;
        private MetroFramework.Controls.MetroLabel lblGpuMem;
        private MetroFramework.Controls.MetroButton btnUninstall;
        private System.Windows.Forms.NumericUpDown numGpuMem;
        private System.Windows.Forms.NumericUpDown numCpuMem;
        private MetroFramework.Controls.MetroButton btnFindGoG;
        private MetroFramework.Controls.MetroButton btnFindSteam;
        private MetroFramework.Components.MetroToolTip tt_gog;
        private MetroFramework.Components.MetroToolTip tt_steam;
        private MetroFramework.Controls.MetroCheckBox cbConsole;
        private MetroFramework.Components.MetroToolTip ttEnableConsole;
    }
}

