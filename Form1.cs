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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DbConnection db = new DbConnection();

           //if (db.TestConnection())
                //MessageBox.Show("BAĞLANTI BAŞARILI 🚀");
            //else
              //MessageBox.Show("BAĞLANTI BAŞARISIZ ❌");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "user" && txtPass.Text.Trim() == "123")
            {
                UserPanel userForm = new UserPanel();
                userForm.Show();
                this.Hide(); // Giriş formunu arka planda gizle
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text.Trim() == "admin" && txtPass.Text.Trim() == "123")
            {
                AdminPanel adminForm = new AdminPanel();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Admin yetkisi bulunamadı!");
            }
        }
    }
}
