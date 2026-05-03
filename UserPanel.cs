using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportakip_application
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbAfter.Image = Image.FromFile(open.FileName);
                pbAfter.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void addPic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbBefore.Image = Image.FromFile(open.FileName);
                pbBefore.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void deletePic1_Click(object sender, EventArgs e)
        {
            if (pbBefore.Image != null)
            {
                pbBefore.Image.Dispose(); // Hafızadan temizle
                pbBefore.Image = null;    // Görüntüyü kaldır
            }
        }

        private void deletePic2_Click(object sender, EventArgs e)
        {
            if (pbAfter.Image != null)
            {
                pbAfter.Image.Dispose();
                pbAfter.Image = null;
            }
        }
    }
}
