using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace CP2077___EasyInstall
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private string _generalPath = string.Empty;
        private Version _modVersion;
        private static int _keyPress = Convert.ToInt32(Keys.Oemtilde);

        private static readonly Version CurrentProgramVersion = Assembly.GetExecutingAssembly().GetName().Version;
        private static readonly string CurrentDir = Directory.GetCurrentDirectory();
        private static readonly string GamePath = ConfigurationManager.AppSettings.Get("GamePath");
        private static readonly string PatchVersion = ConfigurationManager.AppSettings.Get("PatchVersion");

        /// <summary>
        /// Entry point for the application
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            CheckForUpdate();
            _ = InitApplication();
        }

        private bool InitApplication()
        {
            try
            {
                if (GamePath == null)
                {
                    TraceDebugWrite("Patch not already installed!");
                    return true;
                }

                // Check if the patch is already installed. If game_path file != NULL == already installed.
                TraceDebugWrite(GamePath);
                _generalPath = Path.Combine(GamePath, "bin", "x64");
                _modVersion = !Version.TryParse(PatchVersion.Remove(0, 1), out var installedVersion) ? null : installedVersion;
                btnMain.Text = "Patch already installed!";
                EnableGbx(); // Enable settings.
                btnMain.Enabled = false;
                btnFindSteam.Enabled = false;
                btnFindGoG.Enabled = false;

                LoadSettings(_generalPath);
                TraceDebugWrite("Patch already installed!");
                return true;
            }
            catch (Exception ex)
            {
                TraceDebugWrite($"Exception while checking for latest version: {ex}");
                return true;
            }
        }

        /// <summary>
        /// Enable GroupBox + Default values.
        /// </summary>
        private void EnableGbx()
        {
            gbxSettings.Enabled = true;
            gbxConsole.Enabled = true;
            gbxMemPool.Enabled = true;

            cbAVX.Checked = true;
            cbSMT.Checked = true;
            cbSpectre.Checked = true;
            cbVInput.Checked = true;
            cbMemoryPool.Checked = true;
            cbSkipStartMenu.Checked = true;
            cbIntroMovies.Checked = true;
            cbConsole.Checked = true;
        }

        /// <summary>
        /// Disable GroupBox + Default values.
        /// </summary>
        private void DisableGbx()
        {
            gbxSettings.Enabled = false;
            gbxConsole.Enabled = false;
            gbxMemPool.Enabled = false;

            cbAVX.Checked = false;
            cbSMT.Checked = false;
            cbSpectre.Checked = false;
            cbVInput.Checked = false;
            cbMemoryPool.Checked = false;
            cbSkipStartMenu.Checked = false;
            cbIntroMovies.Checked = false;
            cbConsole.Checked = false;
            cbBoundaryTeleport.Checked = false;
            cbAntialiasing.Checked = false;
            cbDebug.Checked = false;
            cbRemovePedestrians.Checked = false;
            cbDumpOption.Checked = false;
            cbAsyncCompute.Checked = false;
            cbVignette.Checked = false;
        }

        private void CheckForUpdate()
        {
            Version latestVersion;

            try
            {
                GitHub response = UpdateUtil.GetGitHubAPIInfo("LittleZen", "Cyberpunk2077-Patch-Easy-Installer");
                latestVersion = !Version.TryParse(response.TagName.Remove(0, 1), out var latestGitHubVersion) ? null : latestGitHubVersion;
            }
            catch (Exception ex)
            {
                TraceDebugWrite($"Exception while checking for latest version: {ex}");
                return;
            }

            if (latestVersion > CurrentProgramVersion)
            {
                var result = MetroFramework.MetroMessageBox.Show(this, "\nA new version is available, would you like to download it?", "New Version!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Process.Start("https://github.com/LittleZen/Cyberpunk2077-Patch-Easy-Installer/releases/latest");
                    Environment.Exit(1);
                }
                else
                {
                    lblUpdate.Text = "Update available, click here!";
                }
            }
        }

        /// <summary>
        /// Load the settings from config.json to autocheck options.
        /// </summary>
        /// <param name="generalPath">Location to main game installation.</param>
        private void LoadSettings(string generalPath)
        {
            try
            {
                var data = JsonConvert.DeserializeObject<Data>(File.ReadAllText(Path.Combine(generalPath, "plugins", "cyber_engine_tweaks", "config.json")));

                cbAVX.Checked = data.AVX;
                numCpuMem.Value = data.CPUMemoryPoolFraction;
                cbAntialiasing.Checked = data.DisableAntialiasing;
                cbAsyncCompute.Checked = data.DisableAsyncCompute;
                numGpuMem.Value = data.GPUMemoryPoolFraction;
                cbMemoryPool.Checked = data.MemoryPool;
                cbRemovePedestrians.Checked = data.RemovePedestrians;
                cbSkipStartMenu.Checked = data.SkipStartMenu;
                cbSMT.Checked = data.SMT;
                cbSpectre.Checked = data.Spectre;
                cbDebug.Checked = data.UnlockMenu;
                cbVInput.Checked = data.VirtualInput;
                cbVInput.Checked = data.VirtualInput;
                cbConsole.Checked = data.Console;
                cbDumpOption.Checked = data.DumpOption;
                cbBoundaryTeleport.Checked = data.DisableBoundaryTeleport;
                cbIntroMovies.Checked = data.DisableIntroMovies;
                cbVignette.Checked = data.DisableVignette;
                numConsoleKey.Value = data.ConsoleKey;
            }
            catch (FileNotFoundException)
            {
                TraceDebugWrite("Settings file not found, create one first.");
            }
        }

        /// <summary>
        /// Initialize the copy function.
        /// </summary>
        /// <param name="sourceDirectory">Source of the files to be copied.</param>
        /// <param name="targetDirectory">Destination of the files to be copied to.</param>
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        /// <summary>
        /// Copy the files from the Patch folder and move them to the
        /// game installation folder.
        /// </summary>
        /// <param name="source">Source of the files to be copied.</param>
        /// <param name="target">Destination of the files to be copied to.</param>
        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (var fi in source.GetFiles())
            {
                TraceDebugWrite($@"Copying {target.FullName}\{fi.Name}");
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (var diSourceSubDir in source.GetDirectories())
            {
                var nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        /// <summary>
        /// Button Main is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnMain_Click(object sender, EventArgs e)
        {
            btnMain.Text = "Working...";
            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();

                if (result == DialogResult.OK &&
                    !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    var gamePath = Path.Combine(fbd.SelectedPath, "bin", "x64");
                    if (string.IsNullOrWhiteSpace(_generalPath))
                    {
                        _generalPath = gamePath;
                    }

                    _ = PatchGame(gamePath);
                    EnableGbx(); //enable the settings after the installation
                }
                else if (result == DialogResult.Cancel)
                {
                    MetroFramework.MetroMessageBox.Show(this, null, "Install Cancelled.", MessageBoxButtons.OK);
                    btnMain.Text = "Select Path to Cyberpunk 2077 Main Directory";
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "The tool wasn't able to open the dialog box!", "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnMain.Text = "Critical Error!";
                }
            }
        }

        /// <summary>
        /// Copy the patch files to the game directory.
        /// </summary>
        /// <param name="gamePath">Location of the game files.</param>
        private bool PatchGame(string gamePath)
        {
            TraceDebugWrite($"Path Selected: {gamePath}", "Message");

            try
            {
                var release = UpdateUtil.GetGitHubAPIInfo("yamashi", "CyberEngineTweaks");
                TraceDebugWrite("Release name: ", release.Assets[0].Name);
                TraceDebugWrite("Version Number: ", release.TagName);

                WriteToSettingsFile("PatchVersion", release.TagName);

                var latestModVersion = !Version.TryParse(release.TagName.Remove(0, 1), out var latestGitHubVersion) ? null : latestGitHubVersion;
                Version installedModVerison = !Version.TryParse(PatchVersion.Remove(0, 1), out var installedVersion) ? null : installedVersion;

                // Check if the mod has already been installed or if there is a new version
                if (_modVersion != null || latestModVersion == _modVersion)
                {
                    MetroFramework.MetroMessageBox.Show(this, "You're already on the latest version!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return true;
                }

                DownloadLatestVersion(); // Create folder called "Patch"(inside patcher directory not CP folder) with all update inside. Function "PatchGame" will install everything from it.

                // Move files from patch to Cyberpunk 2077 path.
                btnMain.Text = "Installing...";
                TraceDebugWrite($"gamePath: {gamePath}");
                Copy("Patch", gamePath);
                SaveModSettings();

                WriteToSettingsFile("GamePath", gamePath);
                

                TraceDebugWrite($"game_path path = {GamePath}");

                // Delete "Patch" working folder.
                var downloadPath = Path.Combine(CurrentDir, "Patch");
                if (Directory.Exists(downloadPath))
                    Directory.Delete(downloadPath, true);

                // Success + set-up interface.
                MetroFramework.MetroMessageBox.Show(this, "Patch successfully installed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                btnMain.Text = "Successfully Installed!";
                btnMain.Enabled = false;
                btnFindSteam.Enabled = false;
                btnFindGoG.Enabled = false;
                return true;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Error during installation {ExceptionAsString(ex)}", "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnMain.Text = "Critical Error!";
                DisableGbx(); // Disable the settings page.
                return true;
            }
        }

        private void WriteToSettingsFile(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[$"{key}"] == null)
            {
                settings.Add($"{key}", value);
            }
            else
            {
                settings[$"{key}"].Value = value;
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        /// <summary>
        /// Button About has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/LittleZen/Cyberpunk2077-Patch-Easy-Installer");
        }

        /// <summary>
        /// Button Save has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveModSettings();
                MetroFramework.MetroMessageBox.Show(this, "\nSaved!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"\nYou must install the patch before save the settings! {ExceptionAsString(ex)}", "Patch not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveModSettings()
        {
            var settingsPath = Path.Combine(_generalPath, "plugins", "cyber_engine_tweaks", "config.json");

            var data = new Data()
            {
                AVX = cbAVX.Checked,
                SMT = cbSMT.Checked,
                Spectre = cbMemoryPool.Checked,
                VirtualInput = cbSpectre.Checked,
                MemoryPool = cbMemoryPool.Checked,
                UnlockMenu = cbDebug.Checked,
                CPUMemoryPoolFraction = numCpuMem.Value,
                GPUMemoryPoolFraction = numGpuMem.Value,
                RemovePedestrians = cbRemovePedestrians.Checked,
                SkipStartMenu = cbSkipStartMenu.Checked,
                DisableAsyncCompute = cbAsyncCompute.Checked,
                DisableAntialiasing = cbAntialiasing.Checked,
                Console = cbConsole.Checked,
                DumpOption = cbDumpOption.Checked,
                DisableBoundaryTeleport = cbBoundaryTeleport.Checked,
                DisableIntroMovies = cbIntroMovies.Checked,
                DisableVignette = cbVignette.Checked,
                ConsoleKey = _keyPress
            };

            using (var file = File.CreateText(settingsPath))
            {
                var serializer = new JsonSerializer
                {
                    Formatting = Formatting.Indented,
                };
                // Serialize object directly into file stream.
                serializer.Serialize(file, data);
            }
        }

        /// <summary>
        /// Button Settings has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                var settingsPath = Path.Combine(_generalPath, "plugins", "cyber_engine_tweaks", "config.json");
                TraceDebugWrite("settingsPath: " + settingsPath);
                Process.Start(settingsPath);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"You must select a valid path before open the settings! {ExceptionAsString(ex)}", "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Pull the latest version of the yamashi fixes.
        /// </summary>
        private void DownloadLatestVersion()
        {
            try
            {
                var release = UpdateUtil.GetGitHubAPIInfo("yamashi", "CyberEngineTweaks").Assets[0].Name; // Downloaded zip name
                var downloadPath = Path.Combine(CurrentDir, "Patch"); // Where temporary extract the file downloaded
                var zipDownloadFile = Path.Combine(CurrentDir, $"{release}.zip"); // Yamashi's zip archive

                btnMain.Text = "Downloading...";

                using (var httpClient = new WebClient())
                {
                    httpClient.DownloadFile($"https://github.com/yamashi/CyberEngineTweaks/releases/latest/download/{release}", zipDownloadFile);
                }

                // Clean downloadPath folder to prevent Exception while trying to extract already exists files
                CleanFolder(downloadPath);

                btnMain.Text = "Extracting...";
                ZipFile.ExtractToDirectory(zipDownloadFile, downloadPath);

                // Delete zip archive, after extract it to Patch Folder
                File.Delete(zipDownloadFile);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Error during downloading {ExceptionAsString(ex)}", "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnMain.Text = "Critical Error!";
                DisableGbx(); //disable the settings page
            }
        }

        private static void CleanFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                return;
            }

            var dirInfo = new DirectoryInfo(folderPath);

            foreach (var file in dirInfo.EnumerateFiles())
            {
                file.Delete();
            }

            foreach (var dir in dirInfo.EnumerateDirectories())
            {
                dir.Delete(true);
            }
        }

        /// <summary>
        /// Button Update has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                PatchGame(GamePath);
                btnMain.Text = "Successfully Installed!";
            }
            catch (Exception ex)
            {
                TraceDebugWrite("Main path not selected, can not check for updates!");
                MetroFramework.MetroMessageBox.Show(this, $"Please select the Cyberpunk 2077 main folder before checking for updates! {ExceptionAsString(ex)}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Button Open Patch Logs has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogs_Click(object sender, EventArgs e)
        {
            var logPath = Path.Combine(_generalPath, "plugins", "cyber_engine_tweaks", "cyber_engine_tweaks.log");
            try
            {
                Process.Start(logPath);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"File not found, you need to run the game at least one time before a log file can be generated! {ExceptionAsString(ex)}", "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button Uninstall has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUninstall_Click(object sender, EventArgs e)
        {
            DisableGbx(); // Turn off all settings before the uninstallation.
            try
            {
                btnMain.Text = "Uninstalling...";

                // Bool is for recursive.
                var directoriesToDelete = new Dictionary<string, bool>
                {
                    { Path.Combine(_generalPath, "plugins"), true },
                };

                foreach (var dir in directoriesToDelete)
                {
                    Directory.Delete(dir.Key, dir.Value);
                    TraceDebugWrite($"{Path.GetFileName(dir.Key)}\t\t DELETED");
                }

                var filesToDelete = new List<string>
                {
                    Path.Combine(_generalPath, "version.dll"),
                    Path.Combine(_generalPath, "global.ini"),
                    Path.Combine(_generalPath, "LICENSE")
                };

                foreach (var file in filesToDelete)
                {
                    File.Delete(file);
                    TraceDebugWrite($"{Path.GetFileName(file)}\t\t DELETED");
                }

                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (!(settings["GamePath"] == null))
                {
                    settings.Remove("GamePath");
                }
                if (!(settings["PatchVersion"] == null))
                {
                    settings.Remove("PatchVersion");
                    _modVersion = null;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

                // Unlock main_button for reinstall the patch.
                btnMain.Text = "Select Path To Cyberpunk 2077 Main Directory";
                btnMain.Enabled = true;
                btnFindSteam.Enabled = true;
                btnFindGoG.Enabled = true;

                MetroFramework.MetroMessageBox.Show(this, "Successfully uninstalled", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Unable to delete mod files.\nPlease remove {_generalPath}\\version.dll and {_generalPath}\\plugins\\ manually.\n {ExceptionAsString(ex)}", "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnMain.Text = "Manually Select Path to Cyberpunk 2077 Main Directory";
            }
        }

        private void btnFindSteam_Click(object sender, EventArgs e)
        {
            GamePathInstaller(sender);
        }

        private void btnFindGoG_Click(object sender, EventArgs e)
        {
            GamePathInstaller(sender);
        }

        private void GamePathInstaller(object sender)
        {
            try
            {
                btnMain.Text = "Working...";
                Button clickedButton = (Button)sender;
                string path = null;

                if (clickedButton.Tag.ToString() == "GOG")
                {
                    path = GOGGamePath.FindGameByAppID("1423049311");
                }
                else if (clickedButton.Tag.ToString() == "Steam")
                {
                    path = SteamGamePath.FindGameByAppID("1091500");
                }

                if (path == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, $"Error: Couldn't Find Cyberpunk for {clickedButton.Tag}!", "Error: File not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TraceDebugWrite($"Error: Couldn't Find Cyberpunk for {clickedButton.Tag}!");
                    btnMain.Text = "Select Path to Cyberpunk 2077 Main Directory";
                    return;
                }

                var result = MetroFramework.MetroMessageBox.Show(this, path, "Is this Correct?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(_generalPath))
                    {
                        _generalPath = Path.Combine(path, "bin", "x64");
                    }

                    PatchGame(Path.Combine(path));
                    EnableGbx(); // Enable the settings after the installation.
                }
                else if (result == DialogResult.No)
                {
                    MetroFramework.MetroMessageBox.Show(this, null, "Installation Cancelled!", MessageBoxButtons.OK);
                    btnMain.Text = "Select Path to Cyberpunk 2077 Main Directory";
                    DisableGbx(); // Disable the Settings page.
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "The tool wasn't able to open the dialog box!", "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DisableGbx(); // Disable the Settings page.
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Error: {ExceptionAsString(ex)}", "Unknown Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TraceDebugWrite("Error" + ex);
                DisableGbx(); // Disable the Settings page.
            }
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            if (lblUpdate.Text == "Update available, click here!")
            {
                Process.Start("https://github.com/LittleZen/Cyberpunk2077-Patch-Easy-Installer/releases/latest");
                Environment.Exit(1);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\nYou are running the latest version!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void txtConsoleKey_KeyUp(object sender, KeyEventArgs e)
        {
            _keyPress = e.KeyValue;
            txtConsoleKey.Text = e.KeyCode.ToString();
            numConsoleKey.Value = e.KeyValue;
            TraceDebugWrite($"Keyboard key pressed: {e.KeyCode} - Value: {_keyPress}");
        }

        private void numConsoleKey_ValueChanged(object sender, EventArgs e)
        {
            _keyPress = Convert.ToInt32(numConsoleKey.Value);
            txtConsoleKey.Text = new KeysConverter().ConvertToString(_keyPress);
        }

        private void cbConsole_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConsole.Checked)
            {
                txtConsoleKey.Enabled = true;
                numConsoleKey.Enabled = true;
            }
            else
            {
                txtConsoleKey.Enabled = false;
                numConsoleKey.Enabled = false;
            }
        }

        // TODO: Move to separate Logger class?
        private static void TraceDebugWrite(string message, string category = null)
        {
#if DEBUG
            Trace.WriteLine(message, category);
#endif
        }

        /// <remarks>
        /// Use it only for MessageBoxes (no StackTrace, because of maximum height for MsgBox)
        /// </remarks>
        /// <param name="exception"></param>
        /// <returns></returns>
        private static string ExceptionAsString(Exception exception)
        {
            var exceptionString = $"{Environment.NewLine}ExceptionMessage: {exception.Message}";

            if (exception.InnerException != null)
            {
                exceptionString += $"{Environment.NewLine}InnerException: {exception.InnerException}";
            }
            return exceptionString;
        }
    }
}
