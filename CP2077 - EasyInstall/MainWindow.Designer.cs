using System;
using System.Windows.Forms;

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
            this.cbVignette = new MetroFramework.Controls.MetroCheckBox();
            this.cbIntroMovies = new MetroFramework.Controls.MetroCheckBox();
            this.cbBoundaryTeleport = new MetroFramework.Controls.MetroCheckBox();
            this.cbDumpOption = new MetroFramework.Controls.MetroCheckBox();
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
            this.cbConsole = new MetroFramework.Controls.MetroCheckBox();
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
            this.ttDumpOption = new MetroFramework.Components.MetroToolTip();
            this.lblUpdate = new MetroFramework.Controls.MetroLabel();
            this.gbxConsole = new System.Windows.Forms.GroupBox();
            this.numConsoleKey = new System.Windows.Forms.NumericUpDown();
            this.txtConsoleKey = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ttIntroMovies = new MetroFramework.Components.MetroToolTip();
            this.ttBoundaryteleport = new MetroFramework.Components.MetroToolTip();
            this.ttVignette = new MetroFramework.Components.MetroToolTip();
            this.ttConsoleKey = new MetroFramework.Components.MetroToolTip();
            this.gbxSettings.SuspendLayout();
            this.gbxMemPool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGpuMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCpuMem)).BeginInit();
            this.gbxConsole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConsoleKey)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(19, 155);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(767, 30);
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
            this.btnAbout.Location = new System.Drawing.Point(714, 605);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(72, 15);
            this.btnAbout.TabIndex = 25;
            this.btnAbout.Text = "About";
            this.btnAbout.UseSelectable = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // gbxSettings
            // 
            this.gbxSettings.Controls.Add(this.cbVignette);
            this.gbxSettings.Controls.Add(this.cbIntroMovies);
            this.gbxSettings.Controls.Add(this.cbBoundaryTeleport);
            this.gbxSettings.Controls.Add(this.cbDumpOption);
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
            this.gbxSettings.Enabled = false;
            this.gbxSettings.Location = new System.Drawing.Point(24, 205);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(762, 149);
            this.gbxSettings.TabIndex = 3;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Settings:";
            // 
            // cbVignette
            // 
            this.cbVignette.AutoSize = true;
            this.cbVignette.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbVignette.Location = new System.Drawing.Point(577, 71);
            this.cbVignette.Name = "cbVignette";
            this.cbVignette.Size = new System.Drawing.Size(125, 19);
            this.cbVignette.TabIndex = 19;
            this.cbVignette.Text = "Disable Vignette";
            this.ttVignette.SetToolTip(this.cbVignette, "Disable the vignette mode");
            this.cbVignette.UseSelectable = true;
            // 
            // cbIntroMovies
            // 
            this.cbIntroMovies.AutoSize = true;
            this.cbIntroMovies.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbIntroMovies.Location = new System.Drawing.Point(172, 96);
            this.cbIntroMovies.Name = "cbIntroMovies";
            this.cbIntroMovies.Size = new System.Drawing.Size(151, 19);
            this.cbIntroMovies.TabIndex = 18;
            this.cbIntroMovies.Text = "Disable Intro Movies";
            this.ttIntroMovies.SetToolTip(this.cbIntroMovies, "Disable the intro movies, and directly show the menu");
            this.cbIntroMovies.UseSelectable = true;
            // 
            // cbBoundaryTeleport
            // 
            this.cbBoundaryTeleport.AutoSize = true;
            this.cbBoundaryTeleport.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbBoundaryTeleport.Location = new System.Drawing.Point(172, 121);
            this.cbBoundaryTeleport.Name = "cbBoundaryTeleport";
            this.cbBoundaryTeleport.Size = new System.Drawing.Size(185, 19);
            this.cbBoundaryTeleport.TabIndex = 17;
            this.cbBoundaryTeleport.Text = "Disable Boundary Teleport";
            this.ttBoundaryteleport.SetToolTip(this.cbBoundaryTeleport, "Delete the teleport caused by going beyond the boundary in the game ");
            this.cbBoundaryTeleport.UseSelectable = true;
            // 
            // cbDumpOption
            // 
            this.cbDumpOption.AutoSize = true;
            this.cbDumpOption.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbDumpOption.Location = new System.Drawing.Point(379, 121);
            this.cbDumpOption.Name = "cbDumpOption";
            this.cbDumpOption.Size = new System.Drawing.Size(150, 19);
            this.cbDumpOption.TabIndex = 16;
            this.cbDumpOption.Text = "Dump Game Option";
            this.ttDumpOption.SetToolTip(this.cbDumpOption, "Will dump all options and their default values in the log file");
            this.cbDumpOption.UseSelectable = true;
            // 
            // cbAntialiasing
            // 
            this.cbAntialiasing.AutoSize = true;
            this.cbAntialiasing.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbAntialiasing.Location = new System.Drawing.Point(379, 46);
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
            this.cbSkipStartMenu.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbSkipStartMenu.Location = new System.Drawing.Point(172, 71);
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
            this.cbRemovePedestrians.Location = new System.Drawing.Point(379, 96);
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
            this.cbAsyncCompute.Location = new System.Drawing.Point(577, 46);
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
            this.lblSettingsText.Location = new System.Drawing.Point(284, 16);
            this.lblSettingsText.Name = "lblSettingsText";
            this.lblSettingsText.Size = new System.Drawing.Size(175, 19);
            this.lblSettingsText.TabIndex = 12;
            this.lblSettingsText.Text = "Check the box for activate it:";
            // 
            // cbVInput
            // 
            this.cbVInput.AutoSize = true;
            this.cbVInput.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbVInput.Location = new System.Drawing.Point(26, 121);
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
            this.cbDebug.Location = new System.Drawing.Point(379, 71);
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
            this.cbMemoryPool.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbMemoryPool.Location = new System.Drawing.Point(172, 46);
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
            this.cbSpectre.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbSpectre.Location = new System.Drawing.Point(26, 96);
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
            this.cbSMT.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbSMT.Location = new System.Drawing.Point(26, 71);
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
            this.cbAVX.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbAVX.Location = new System.Drawing.Point(26, 46);
            this.cbAVX.Name = "cbAVX";
            this.cbAVX.Size = new System.Drawing.Size(50, 19);
            this.cbAVX.TabIndex = 5;
            this.cbAVX.Tag = "";
            this.cbAVX.Text = "AVX";
            this.tt_avx.SetToolTip(this.cbAVX, "Fixes a crash when playing the game with a CPU that does not support AVX");
            this.cbAVX.UseSelectable = true;
            // 
            // cbConsole
            // 
            this.cbConsole.AutoSize = true;
            this.cbConsole.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbConsole.Location = new System.Drawing.Point(16, 19);
            this.cbConsole.Name = "cbConsole";
            this.cbConsole.Size = new System.Drawing.Size(118, 19);
            this.cbConsole.TabIndex = 15;
            this.cbConsole.Text = "Enable Console";
            this.ttEnableConsole.SetToolTip(this.cbConsole, "Adds an overlay to draw whatever UI you want on top of the game.\nPress the \'End\' " +
        "key to toggle the console");
            this.cbConsole.UseSelectable = true;
            this.cbConsole.CheckedChanged += new System.EventHandler(this.cbConsole_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(24, 569);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Check For Patch &Updates";
            this.tt_checkUpdate.SetToolTip(this.btnUpdate, "Download and install the latest patch version available");
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(22, 532);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(764, 31);
            this.btnSettings.TabIndex = 22;
            this.btnSettings.Text = "&Open JSON Settings";
            this.tt_json.SetToolTip(this.btnSettings, "Open JSON settings, for manual editing");
            this.btnSettings.UseSelectable = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 458);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(764, 31);
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
            this.btnLogs.Location = new System.Drawing.Point(22, 495);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(764, 31);
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
            this.gbxMemPool.Enabled = false;
            this.gbxMemPool.Location = new System.Drawing.Point(24, 360);
            this.gbxMemPool.Name = "gbxMemPool";
            this.gbxMemPool.Size = new System.Drawing.Size(356, 92);
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
            this.numGpuMem.Location = new System.Drawing.Point(135, 57);
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
            this.numCpuMem.Location = new System.Drawing.Point(135, 19);
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
            this.lblGpuMem.Location = new System.Drawing.Point(6, 57);
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
            this.btnUninstall.Location = new System.Drawing.Point(611, 569);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(175, 23);
            this.btnUninstall.TabIndex = 24;
            this.btnUninstall.Text = "&Uninstall";
            this.btnUninstall.UseSelectable = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnFindGoG
            // 
            this.btnFindGoG.Location = new System.Drawing.Point(19, 83);
            this.btnFindGoG.Name = "btnFindGoG";
            this.btnFindGoG.Size = new System.Drawing.Size(767, 30);
            this.btnFindGoG.TabIndex = 2;
            this.btnFindGoG.Tag = "GOG";
            this.btnFindGoG.Text = "Automatic Detect GOG Path";
            this.btnFindGoG.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tt_gog.SetToolTip(this.btnFindGoG, "Automatically Detect GOG Path");
            this.btnFindGoG.UseSelectable = true;
            this.btnFindGoG.Click += new System.EventHandler(this.btnFindGoG_Click);
            // 
            // btnFindSteam
            // 
            this.btnFindSteam.Location = new System.Drawing.Point(19, 119);
            this.btnFindSteam.Name = "btnFindSteam";
            this.btnFindSteam.Size = new System.Drawing.Size(767, 30);
            this.btnFindSteam.TabIndex = 1;
            this.btnFindSteam.Tag = "Steam";
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
            // ttDumpOption
            // 
            this.ttDumpOption.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttDumpOption.StyleManager = null;
            this.ttDumpOption.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUpdate.Location = new System.Drawing.Point(22, 605);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(261, 15);
            this.lblUpdate.TabIndex = 26;
            this.lblUpdate.Text = "You are currently running the latest version available";
            this.lblUpdate.Click += new System.EventHandler(this.lblUpdate_Click);
            // 
            // gbxConsole
            // 
            this.gbxConsole.Controls.Add(this.numConsoleKey);
            this.gbxConsole.Controls.Add(this.txtConsoleKey);
            this.gbxConsole.Controls.Add(this.metroLabel1);
            this.gbxConsole.Controls.Add(this.cbConsole);
            this.gbxConsole.Enabled = false;
            this.gbxConsole.Location = new System.Drawing.Point(387, 361);
            this.gbxConsole.Name = "gbxConsole";
            this.gbxConsole.Size = new System.Drawing.Size(399, 91);
            this.gbxConsole.TabIndex = 27;
            this.gbxConsole.TabStop = false;
            this.gbxConsole.Text = "Console:";
            // 
            // numConsoleKey
            // 
            this.numConsoleKey.Location = new System.Drawing.Point(255, 46);
            this.numConsoleKey.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numConsoleKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numConsoleKey.Name = "numConsoleKey";
            this.numConsoleKey.Size = new System.Drawing.Size(45, 20);
            this.numConsoleKey.TabIndex = 20;
            this.numConsoleKey.Value = new decimal(new int[] {
            192,
            0,
            0,
            0});
            this.numConsoleKey.ValueChanged += new System.EventHandler(this.numConsoleKey_ValueChanged);
            // 
            // txtConsoleKey
            // 
            // 
            // 
            // 
            this.txtConsoleKey.CustomButton.Image = null;
            this.txtConsoleKey.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtConsoleKey.CustomButton.Name = "";
            this.txtConsoleKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsoleKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsoleKey.CustomButton.TabIndex = 1;
            this.txtConsoleKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsoleKey.CustomButton.UseSelectable = true;
            this.txtConsoleKey.CustomButton.Visible = false;
            this.txtConsoleKey.Lines = new string[] {
        "Oemtilde"};
            this.txtConsoleKey.Location = new System.Drawing.Point(122, 43);
            this.txtConsoleKey.MaxLength = 1;
            this.txtConsoleKey.Name = "txtConsoleKey";
            this.txtConsoleKey.PasswordChar = '\0';
            this.txtConsoleKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsoleKey.SelectedText = "";
            this.txtConsoleKey.SelectionLength = 0;
            this.txtConsoleKey.SelectionStart = 0;
            this.txtConsoleKey.ShortcutsEnabled = true;
            this.txtConsoleKey.Size = new System.Drawing.Size(127, 23);
            this.txtConsoleKey.TabIndex = 19;
            this.txtConsoleKey.Text = "Oemtilde";
            this.txtConsoleKey.UseSelectable = true;
            this.txtConsoleKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsoleKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtConsoleKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConsoleKey_KeyUp);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Console Key:";
            this.ttConsoleKey.SetToolTip(this.metroLabel1, resources.GetString("metroLabel1.ToolTip"));
            // 
            // ttIntroMovies
            // 
            this.ttIntroMovies.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttIntroMovies.StyleManager = null;
            this.ttIntroMovies.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ttBoundaryteleport
            // 
            this.ttBoundaryteleport.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttBoundaryteleport.StyleManager = null;
            this.ttBoundaryteleport.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ttVignette
            // 
            this.ttVignette.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttVignette.StyleManager = null;
            this.ttVignette.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ttConsoleKey
            // 
            this.ttConsoleKey.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttConsoleKey.StyleManager = null;
            this.ttConsoleKey.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 625);
            this.Controls.Add(this.gbxConsole);
            this.Controls.Add(this.lblUpdate);
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
            this.Text = "CP 2077 - EasyPatcher | v3.5";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.gbxSettings.ResumeLayout(false);
            this.gbxSettings.PerformLayout();
            this.gbxMemPool.ResumeLayout(false);
            this.gbxMemPool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGpuMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCpuMem)).EndInit();
            this.gbxConsole.ResumeLayout(false);
            this.gbxConsole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConsoleKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MetroFramework.Controls.MetroCheckBox cbDumpOption;
        private MetroFramework.Components.MetroToolTip ttDumpOption;
        private MetroFramework.Controls.MetroLabel lblUpdate;
        private System.Windows.Forms.GroupBox gbxConsole;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox cbVignette;
        private MetroFramework.Controls.MetroCheckBox cbIntroMovies;
        private MetroFramework.Controls.MetroCheckBox cbBoundaryTeleport;
        private MetroFramework.Components.MetroToolTip ttIntroMovies;
        private MetroFramework.Components.MetroToolTip ttVignette;
        private MetroFramework.Components.MetroToolTip ttBoundaryteleport;
        private MetroFramework.Controls.MetroTextBox txtConsoleKey;
        private NumericUpDown numConsoleKey;
        private MetroFramework.Components.MetroToolTip ttConsoleKey;
    }
}
