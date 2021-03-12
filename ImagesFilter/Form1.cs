using ImagesFilter.Logic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImagesFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IImageFilter filter = new RotateLeft();
            var img = pictureBox1.Image;
            filter.Perform(img);
            pictureBox1.Image = img;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IImageFilter filter = new RotateRight();
            var img = pictureBox1.Image;
            filter.Perform(img);
            pictureBox1.Image = img;
        }
    }
}