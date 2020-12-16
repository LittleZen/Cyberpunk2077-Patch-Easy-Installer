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
        string generalPath = ""; // Main x64 path.
        bool alreadyInstalled = false; // Check if the patch is already installed, for directly manage the menu.
        public Form1()
        {
            InitializeComponent();

            try
            {
                // Check if the patch is already installed. If game_path file != NULL == already installed.
                var localPath = Directory.GetCurrentDirectory() + "\\game_path";

                string myPath = File.ReadAllText(localPath);
                Console.WriteLine(myPath);
                generalPath = myPath;
                alreadyInstalled = true;
                btnMain.Text = "Patch Already Installed!";
                btnMain.Enabled = false;
                Console.WriteLine("Patch already installed!");
            }
            catch (Exception)
            {
                Console.WriteLine("Patch not already installed!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // if path.txt exist and != null --> already patched!
        }

        // Initialize the copy function
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        // Start patching (Copy Function)
        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine($"Copying {target.FullName}\\{fi.Name}");
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

        public void btnMain_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string main_path = fbd.SelectedPath;  // Refers to main CP2077 directory.
                    fbd.SelectedPath += "\\bin\\x64";
                    generalPath = fbd.SelectedPath; // Refers to x64 directory.

#if DEBUG
                    MessageBox.Show("Path Selected: " + fbd.SelectedPath, "Message");
#endif
                    try
                    {
                        DownloadLatestVersion();
                        // Move files from patch to Cyberpunk2077 path.
                        string sourceDirectory = @"Patch";
                        string targetDirectory = fbd.SelectedPath;
                        Copy(sourceDirectory, targetDirectory);

                        string docPath = Directory.GetCurrentDirectory();
                        StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Path.txt"));
                        outputFile.Write(fbd.SelectedPath);

                        /* WRITE PATH FILE. IT IS USED FOR CHECK IF THE PATCH IS ALREADY INSTALLED (ON NEXT RESTART) */
                        try
                        {
                            var localPath = Directory.GetCurrentDirectory() + "\\game_path";
#if DEBUG
                            Console.WriteLine("path.txt path = ", localPath);
#endif
                            File.WriteAllText(localPath, generalPath);
#if DEBUG
                            Console.WriteLine("Path correctly created!\n");
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
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error during installation\nError code: 2", "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnMain.Text = "Critical Error!";
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Process.Start("https://bit.ly/385MEvl");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string settingsPath = generalPath + "\\plugins\\cyber_engine_tweaks\\" + "config.json"; // path

            bool avxSet = cbAVX.Checked;
            bool smtSet = cbSMT.Checked;
            bool memorySet = cbMemoryPool.Checked;
            bool spectreSet = cbSpectre.Checked;
            bool debugSet = cbDebug.Checked;
            bool vInputSet = cbVInput.Checked;
            bool asyncCompute = cbAsyncCompute.Checked;
            bool removePedestrians = cbRemovePedestrians.Checked;
            bool skipStartMenu = cbSkipStartMenu.Checked;

            var data = new Data()
            {
                AVX = avxSet,
                CPUMemoryPoolFraction = 0.5,
                GPUMemoryPoolFraction = 1.0,
                MemoryPool = memorySet,
                SMT = smtSet,
                Spectre = spectreSet,
                UnlockMenu = debugSet,
                VirtualInput = vInputSet,
                AsyncCompute = asyncCompute,
                RemovePedestrians = removePedestrians,
                SkipStartMenu = skipStartMenu
            };

            using (StreamWriter file = File.CreateText(settingsPath))
            {
                JsonSerializer serializer = new JsonSerializer();
                // Serialize object directly into file stream.
                serializer.Serialize(file, data);
            }
            MetroFramework.MetroMessageBox.Show(this, "Saved!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                string settingsPath = generalPath + "\\plugins\\cyber_engine_tweaks\\" + "config.json"; // path
                Process.Start(settingsPath);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select a valid path before open the settings!\nError code: 3", "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DownloadLatestVersion()
        {
            string DownloadPath = Directory.GetCurrentDirectory() + "\\Patch";
            FileStream zipFile = File.Create($"{Directory.GetCurrentDirectory()}\\Release.zip");
            zipFile.Close();

            using (var httpclient = new WebClient())
            {
                httpclient.DownloadFile("https://github.com/yamashi/PerformanceOverhaulCyberpunk/releases/latest/download/Release.zip", $"{Directory.GetCurrentDirectory()}\\Release.zip");
            }

            if (Directory.Exists(DownloadPath))
                Directory.Delete(DownloadPath, true);

            ZipFile.ExtractToDirectory($"{Directory.GetCurrentDirectory()}\\Release.zip", DownloadPath);
        }
    }
}
