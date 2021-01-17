using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGMakerSpriteTools
{
    public partial class RMSTMenu : Form
    {
        public RMSTMenu()
        {
            InitializeComponent();
        }

        private void OpenFaceMenu_Click(object sender, EventArgs e)
        {
            Hide();
            FaceGenerator fg = new FaceGenerator();
            fg.FormClosed += (s, arg) =>
            {
                Show();
            };
            fg.ShowDialog();
        }

        private void OpenIconMenu_Click(object sender, EventArgs e)
        {
            Hide();
            IconsetGenerator fg = new IconsetGenerator();
            fg.FormClosed += (s, arg) =>
            {
                Show();
            };
            fg.ShowDialog();
        }
    }
}
