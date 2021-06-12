﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrainzTextureTxtCreator
{
    public partial class fMain : Form
    {

        private string ImagePath
        {
            get { return Properties.Settings.Default.FolderPath; }
            set { Properties.Settings.Default.FolderPath = value; }
            
        }
        public fMain()
        {
            InitializeComponent();
        }

        private void cmdSelectFolder_Click(object sender, EventArgs e)
        {
            fbd.SelectedPath = ImagePath;
            if (fbd.ShowDialog() == DialogResult.OK) {
                ImagePath = fbd.SelectedPath;
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveSettings()
        {
            Properties.Settings.Default.Save();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            eFolderPath.Text = ImagePath;
            if (ImagePath.Length > 0)
            {
                this.ActiveControl = cmdGO;
            }
        }

        private void cmdGO_Click(object sender, EventArgs e)
        {
            ImagePath = eFolderPath.Text;
            List<string> files = Directory.GetFiles(Path.Combine(ImagePath), "*.png").ToList<string>();
            //IEnumerable<string> normals = files.Where(file => file.Contains("normal.png"));

            lbLog.Items.Add($"Started processing {ImagePath}...");
            int itemIx = 0;
            bool recognized;

            foreach (string file in files)
            {
                string pureFileName = Path.GetFileNameWithoutExtension(file);
                string contents = "";
                recognized = false;

                if (    file.Contains("albedo.png") 
                    ||  file.Contains("basecolor.png") 
                    ||  file.Contains("base_color.png") 
                    ||  file.Contains("diffuse.png")
                   )
                {
                    recognized = true;
                    contents += $"Primary={pureFileName}.png\r\n";
                    contents += $"Tile=st";                    
                    lbLog.Items.Add($"{++itemIx + ".",-3}\tCreated albedo descriptor for {Path.GetFileName(file)}");
                }

                if (file.Contains("normal.png"))
                {
                    recognized = true;
                    contents += $"Primary={pureFileName}.png\r\n";
                    contents += $"Alpha={pureFileName}.png\r\n";
                    contents += $"NormalMapHint=normalmap\r\n";
                    contents += $"Tile=st";
                    lbLog.Items.Add($"{++itemIx + ".", -3}\tCreated normal descriptor for {Path.GetFileName(file)}");
                }

                if (    file.Contains("parameter.png") 
                    ||  file.Contains("parameters.png"))
                {
                    recognized = true;
                    contents += $"Primary={pureFileName}.png\r\n";
                    contents += $"Alpha={pureFileName}.png\r\n";
                    contents += $"MipAlgorithm=no-weight-by-alpha\r\n";
                    contents += $"NormalMapHint=none\r\n";
                    contents += $"Tile=st";
                    lbLog.Items.Add($"{++itemIx + ".", -3}\tCreated parameter descriptor for {Path.GetFileName(file)}");
                }

                if (recognized)
                {
                    string textureFile = Path.Combine(ImagePath, pureFileName + ".texture.txt");
                    File.WriteAllText(textureFile, contents, Encoding.ASCII);
                    lbLog.Items.Add($"\t\tFile {textureFile} written successfully");
                } 
                else
                {
                    lbLog.Items.Add($"***\tFile {Path.GetFileName(file)} not recognized, no texture file created");
                }
            }
            lbLog.Items.Add($"Done");

        }

        private void menuCommandAbout_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void menuCommandHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/gusztavj/TrainzTextureTxtCreator");
        }
    }
}
