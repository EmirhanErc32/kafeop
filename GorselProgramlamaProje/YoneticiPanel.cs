using System.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaProje
{
    public partial class YoneticiPanel : Form
    {
        public YoneticiPanel()
        {
            InitializeComponent();
        }

        private void YoneticiPanel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AdminGiris AdminGiris = new AdminGiris();
            AdminGiris.Show();
            this.Hide();
        }
        private void LoadContent(UserControl userControl)
        {
            ortakpanel.Controls.Clear(); // Eski içeriği sil
            userControl.Dock = DockStyle.Fill; // Paneli doldur
            ortakpanel.Controls.Add(userControl); // Yeni içeriği ekle
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadContent(new Stok());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadContent(new ciro());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadContent(new menu());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadContent(new personel());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadContent(new yoneticimenu());
        }
    }
}
