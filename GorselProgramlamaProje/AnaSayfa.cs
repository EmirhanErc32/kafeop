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
    public partial class AnaSayfa : Form
    {
        private void trans_panel(PictureBox pictureBox, string text) {
            // Yarı saydam panel oluştur
            Panel overlay = new Panel
            {
                BackColor = Color.FromArgb(95, 0, 0, 0), // 128 = şeffaflık
                Location = new Point(0, 0),
                Size = pictureBox.Size

            };

            //Yazı (label ile)
            Label label = new Label
            {
                Text = text,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                
            };
            overlay.Controls.Add(label);
            pictureBox.Controls.Add(overlay);
            overlay.BringToFront();
        }
            
            

        


        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btn_grs_Click(object sender, EventArgs e)
        {

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {


            // PictureBox üzerine ekle
            trans_panel(khvlt_pic, "KAHVALTI");
            trans_panel(atstr_pic, "ATIŞTIRMALIKLAR");
            trans_panel(anaymk_pic, "ANA YEMEK");
            trans_panel(tatli_pic, "TATLI");
            trans_panel(sck_pic,"SICAK İÇECEKLER");
            trans_panel(sgk_pic, "SOĞUK İÇECEKLER");
        }
    }
}
