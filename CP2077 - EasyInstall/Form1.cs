using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CP2077___EasyInstall
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string general_path = ""; //main x64 path
        bool already_installed = false; //check if the patch is already installed, for directly manage the menu
        public Form1()
        {
            InitializeComponent();

            try
            {
                /* Check if the patch is already installed. If game_path file != NULL == already installed */
                var local_path = Directory.GetCurrentDirectory() + "\\game_path";

                string mypath = File.ReadAllText(local_path);
                Console.WriteLine(mypath);
                general_path = mypath;
                already_installed = true;
                btn_main.Text = "Patch Already Installed!";
                btn_main.Enabled = false;
                Console.WriteLine("Patch already installed!");
            }
            catch(Exception)
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
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
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

        public void btn_main_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //fbd.SelectedPath = <path selected>
                    string main_path = fbd.SelectedPath;  //refers to main CP2077 directory
                    fbd.SelectedPath += "\\bin\\x64";
                    general_path = fbd.SelectedPath; //refers to x64 directory

                    //System.Windows.Forms.MessageBox.Show("Path Selected: " + fbd.SelectedPath, "Message"); <DEBUG>
                    try
                    {
                        // Move files from patch to Cyberpunk2077 path
                        string sourceDirectory = @"Patch";
                        string targetDirectory = fbd.SelectedPath;
                        Copy(sourceDirectory, targetDirectory);

                        string docPath = Directory.GetCurrentDirectory();
                        StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Path.txt"));
                        outputFile.Write(fbd.SelectedPath);

                        /* WRITE PATH FILE. IT IS USED FOR CHECK IF THE PATCH IS ALREADY INSTALLED (ON NEXT RESTART) */
                        try 
                        {
                            var local_path = Directory.GetCurrentDirectory() + "\\game_path";
                            Console.WriteLine("path.txt path = ", local_path); //debug
                            File.WriteAllText(local_path, general_path);
                            Console.WriteLine("Path correctly created!\n"); //debug
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Patch successfully installed, but i wasn't able to create path.txt file for correctly detect the position!");
                        }

                        MetroFramework.MetroMessageBox.Show(this, "Patch successfully installed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        btn_main.Text = "Successfully Installed!";
                        btn_main.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Error during installation\nError code: 1", "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btn_main.Text = "Critical Error!";
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error during installation\nError code: 2", "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_main.Text = "Critical Error!";
                }
            }       
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
           Process.Start("https://bit.ly/385MEvl");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string settings_path = general_path + "\\plugins\\cyber_engine_tweaks\\" + "config.json"; //path

            bool avx_set = cb_avx.Checked;
            bool smt_set = cb_smt.Checked;
            bool memory_set = cb_memory.Checked;
            bool spectre_set = cb_spectre.Checked;
            bool debug_set = cb_debug.Checked;
            bool vinput_set = cb_vinput.Checked;

            var data = new data()
            {
                avx = avx_set,
                cpu_memory_pool_fraction = 0.5,
                gpu_memory_pool_fraction = 1.0,
                memory_pool = memory_set,
                smt = smt_set,
                spectre = spectre_set,
                unlock_menu = debug_set,
                virtual_input = vinput_set
            };
           
            using (StreamWriter file = File.CreateText(settings_path))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, data);
            }
            MetroFramework.MetroMessageBox.Show(this, "Saved!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string settings_path = general_path + "\\plugins\\cyber_engine_tweaks\\" + "config.json"; //path
                Process.Start(settings_path);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select a valid path before open the settings!\nError code: 3", "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
