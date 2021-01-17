using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGMakerSpriteTools
{
    public partial class IconsetGenerator : Form
    {
        public IconsetGenerator()
        {
            InitializeComponent();
        }

        private void SourceDirButton_Click(object sender, EventArgs e)
        {
            bool? v = SourceDirDialog.ShowDialog();
            if (v != null && (bool)v)
            {
                SelectedInputDir = SourceDirDialog.SelectedPath;
            } else
            {
                SelectedInputDir = "";
            }
            SourceDirText.Text = SelectedInputDir;
            UpdateStartButton();
        }

        private void OutputDirButton_Click(object sender, EventArgs e)
        {
            bool? v = OutputDirDialog.ShowDialog();
            if (v != null && (bool)v)
            {
                SelectedOutputDir = OutputDirDialog.FileName;
            } else
            {
                SelectedOutputDir = "";
            }
            OutputDirText.Text = SelectedOutputDir;
            UpdateStartButton();
        }

        private void UpdateStartButton()
        {
            StartButton.Enabled = !string.IsNullOrWhiteSpace(SelectedInputDir) && !string.IsNullOrWhiteSpace(SelectedOutputDir) &&
                !string.IsNullOrWhiteSpace(ExtensionInput.Text);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StatusText.Visible = true;
            StatusText.Text = "";

            string[] images = Directory.GetFiles(SelectedInputDir, "*." + ExtensionInput.Text);
            int totalRows = (int) Math.Ceiling(images.Length / 16f);

            if (AreNumbered.Checked)
            {
                Array.Sort(images, (a, b) =>
                {
                    a = Path.GetFileNameWithoutExtension(Path.GetFileName(a));
                    b = Path.GetFileNameWithoutExtension(Path.GetFileName(b));
                    int aInt = int.Parse(a);
                    int bInt = int.Parse(b);

                    return aInt - bInt;
                });
            }

            Bitmap newImg = new Bitmap(32 * 16, totalRows * 32);
            Graphics g = Graphics.FromImage(newImg);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            for (int i = 0; i < images.Length; i++)
            {
                Image face = ResizeBitmap(Image.FromFile(images[i]));
                g.DrawImage(face, (int)(i % 16) * 32, (int)Math.Floor(i / 16f) * 32);

                face.Dispose();
            }

            newImg.Save(SelectedOutputDir);
            newImg.Dispose();
            g.Dispose();

            StatusText.Text = "Complete!";
        }

        private Bitmap ResizeBitmap(Image source)
        {
            Bitmap final = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(final))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(source, 0, 0, 32, 32);
            }
            source.Dispose();
            return final;
        }

        private void ExtensionInput_TextChanged(object sender, EventArgs e)
        {
            UpdateStartButton();
        }
    }
}
