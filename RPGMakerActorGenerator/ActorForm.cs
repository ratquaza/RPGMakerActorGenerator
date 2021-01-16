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

namespace RPGMakerActorGenerator
{
    public partial class ActorForm : Form
    {
        public ActorForm()
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
                SelectedOutputDir = OutputDirDialog.SelectedPath;
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
            int totalImages = (int)Math.Ceiling(images.Length / 8f);

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

            for (int i = 0; i < totalImages; i++)
            {
                Bitmap newImg = new Bitmap(144 * 4, 144 * 2);
                Graphics g = Graphics.FromImage(newImg);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

                var arr = images.Skip(i * 8).Take(8);
                int index = 0;

                foreach (string value in arr)
                {
                    int xPos = index < 4 ? index : index - 4;
                    int yPos = index < 4 ? 0 : 1;
                    Image face = ResizeBitmap(Image.FromFile(value));

                    g.DrawImage(face, xPos * 144, yPos * 144);
                    index++;

                    face.Dispose();
                }

                newImg.Save(SelectedOutputDir + "\\" + PrefixText.Text + (i + 1).ToString() + ".png");
                newImg.Dispose();
                g.Dispose();
            }

            StatusText.Text = "Complete!";
        }

        private Bitmap ResizeBitmap(Image source)
        {
            Bitmap final = new Bitmap(144, 144);
            using (Graphics g = Graphics.FromImage(final))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(source, 0, 0, 145, 145);
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
