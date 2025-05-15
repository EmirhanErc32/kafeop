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
    public partial class SicakIcecek : Form
    {
        public SicakIcecek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa yeniForm = new AnaSayfa();
            yeniForm.Show();
            this.Close();
        }
    }
}
