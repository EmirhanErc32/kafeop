using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace GorselProgramlamaProje
{
    public partial class AnaYemek : Form
    {
        public AnaYemek()
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
