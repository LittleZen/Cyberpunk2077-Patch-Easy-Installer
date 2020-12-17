using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CP2077___EasyInstall
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string generalPath = string.Empty; // Main x64 path.

        /// <summary>
        /// Entry point for the application
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            try
            {
                // Check if the patch is already installed. If game_path file != NULL == already installed.
                var localPath = $"{Directory.GetCurrentDirectory()}\\game_path";

                string myPath = File.ReadAllText(localPath);
#if DEBUG
                MessageBox.Show(myPath);
#endif
                generalPath = myPath;
                btnMain.Text = "Patch Already Installed!";
                btnMain.Enabled = false;
#if DEBUG
                MessageBox.Show("Patch already installed!");
#endif
            }
            catch (Exception)
            {
#if DEBUG
                MessageBox.Show("Patch not already installed!");
#endif
            }
        }

        /// <summary>
        /// Initial Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Initialize the copy function.
        /// </summary>
        /// <param name="sourceDirectory">Source of the files to be copied.</param>
        /// <param name="targetDirectory">Destination of the files to be copied to.</param>
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

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
            foreach (FileInfo fi in source.GetFiles())
            {
#if DEBUG
                MessageBox.Show($"Copying {target.FullName}\\{fi.Name}");
#endif
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
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
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string gamePath = $"{fbd.SelectedPath}\\bin\\x64";
                    if (generalPath == string.Empty)
                    {
                        generalPath = gamePath;
                    }
                    PatchGame(gamePath);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error during installation\nError code: 2", "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnMain.Text = "Critical Error!";
                }
            }
        }

        /// <summary>
        /// Copy the patch files to the game directory.
        /// </summary>
        /// <param name="gamePath">Location of the game files.</param>
        private void PatchGame(string gamePath)
        {
#if DEBUG
            MessageBox.Show($"Path Selected: {gamePath}", "Message");
#endif
            try
            {
                DownloadLatestVersion();
                // Move files from patch to Cyberpunk 2077 path.
                btnMain.Text = "Installing";
                string targetDirectory = gamePath;
                Copy("Patch", targetDirectory);

                string docPath = Directory.GetCurrentDirectory();
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Path.txt")))
                {
                    outputFile.Write(gamePath);
                }

                // Write Path file. It is used for checking if the patch has already been installed (on next restart)
                try
                {
                    var localPath = $"{Directory.GetCurrentDirectory()}\\game_path";
#if DEBUG
                    MessageBox.Show($"path.txt path = {localPath}");
#endif
                    File.WriteAllText(localPath, gamePath);
#if DEBUG
                    MessageBox.Show("Path correctly created!\n");
#endif
                }
                catch (Exception)
                {
                    MessageBox.Show("Patch successfully installed, but I wasn't able to create path.txt file for correctly detect the position!");
                }

                MetroFramework.MetroMessageBox.Show(this, "Patch successfully installed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                btnMain.Text = "Successfully Installed!";
                btnMain.Enabled = false;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Error during installation\nError code: 1\n{ex.InnerException}", "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnMain.Text = "Critical Error!";
            }
        }

        /// <summary>
        /// Button About has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            Process.Start("https://bit.ly/385MEvl");
        }

        /// <summary>
        /// Button Save has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string settingsPath = $"{generalPath}\\plugins\\cyber_engine_tweaks\\config.json";

            bool avxSet = cbAVX.Checked;
            bool smtSet = cbSMT.Checked;
            bool memorySet = cbMemoryPool.Checked;
            bool spectreSet = cbSpectre.Checked;
            bool debugSet = cbDebug.Checked;
            bool vInputSet = cbVInput.Checked;
            bool asyncCompute = cbAsyncCompute.Checked;
            bool removePedestrians = cbRemovePedestrians.Checked;
            bool skipStartMenu = cbSkipStartMenu.Checked;
            bool antialiasing = cbAntialiasing.Checked;

            var data = new Data()
            {
                avx = avxSet,
                smt = smtSet,
                spectre = spectreSet,
                virtual_input = vInputSet,
                memory_pool = memorySet,
                unlock_menu = debugSet,
                cpu_memory_pool_fraction = 0.5,
                gpu_memory_pool_fraction = 1.0,
                remove_pedestrians = removePedestrians,
                skip_start_menu = skipStartMenu,
                disable_async_compute = asyncCompute,
                disable_antialiasing = antialiasing
            };

            using (StreamWriter file = File.CreateText(settingsPath))
            {
                JsonSerializer serializer = new JsonSerializer();
                // Serialize object directly into file stream.
                serializer.Serialize(file, data);
            }
            MetroFramework.MetroMessageBox.Show(this, "Saved!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
                string settingsPath = $"{generalPath}\\plugins\\cyber_engine_tweaks\\config.json";
                Process.Start(settingsPath);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select a valid path before open the settings!\nError code: 3", "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Pull the latest version of the yamashi fixes.
        /// </summary>
        private void DownloadLatestVersion()
        {
            string DownloadPath = $"{Directory.GetCurrentDirectory()}\\Patch";
            FileStream zipFile = File.Create($"{Directory.GetCurrentDirectory()}\\Release.zip");
            zipFile.Close();
            btnMain.Text = "Downloading";

            using (var httpclient = new WebClient())
            {
                httpclient.DownloadFile("https://github.com/yamashi/PerformanceOverhaulCyberpunk/releases/latest/download/Release.zip", $"{Directory.GetCurrentDirectory()}\\Release.zip");
            }

            if (Directory.Exists(DownloadPath))
                Directory.Delete(DownloadPath, true);

            btnMain.Text = "Extracting";
            ZipFile.ExtractToDirectory($"{Directory.GetCurrentDirectory()}\\Release.zip", DownloadPath);
        }

        /// <summary>
        /// Button Update has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = File.ReadAllText($"{Directory.GetCurrentDirectory()}\\game_path");
            PatchGame(path);
            btnMain.Text = "Successfully Installed";
        }
    }
}
