using System;
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
        }

        private void cmdGO_Click(object sender, EventArgs e)
        {
            ImagePath = eFolderPath.Text;
            List<string> files = Directory.GetFiles(Path.Combine(ImagePath), "*.png").ToList<string>();
            //IEnumerable<string> normals = files.Where(file => file.Contains("normal.png"));

            lbLog.Items.Add($"Started processing {ImagePath}...");
            int itemIx = 0;

            foreach (string file in files)
            {
                string pureFileName = Path.GetFileNameWithoutExtension(file);
                string contents = "";

                if (file.Contains("albedo.png"))
                {
                    contents += $"Primary={pureFileName}.png\n";
                    contents += $"Tile=st";
                    lbLog.Items.Add($"{++itemIx}. Created albedo descriptor for {Path.GetFileName(file)}");
                }

                if (file.Contains("normal.png"))
                {
                    contents += $"Primary={pureFileName}.png\n";
                    contents += $"Alpha={pureFileName}.png\n";
                    contents += $"NormalMapHint=normalmap\n";
                    contents += $"Tile=st";
                    lbLog.Items.Add($"{++itemIx}. Created normal descriptor for {Path.GetFileName(file)}");
                }

                if (file.Contains("parameter.png") || file.Contains("parameters.png"))
                {
                    contents += $"Primary={pureFileName}.png\n";
                    contents += $"Alpha={pureFileName}.png\n";
                    contents += $"Tile=st";
                    lbLog.Items.Add($"{++itemIx}. Created parameter descriptor for {Path.GetFileName(file)}");
                }


                string textureFile = Path.Combine(ImagePath, pureFileName + ".texture.txt");
                File.WriteAllText(textureFile, contents);
                lbLog.Items.Add($"\tFile {textureFile} written successfully");
            }
            lbLog.Items.Add($"Done");

        }
    }
}
