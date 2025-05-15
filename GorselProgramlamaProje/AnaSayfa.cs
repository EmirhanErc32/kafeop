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
        private void trans_panel1(PictureBox pictureBox, string text) {
            // Yarı saydam panel oluştur
            Panel overlay = new Panel
            {
                BackColor = Color.FromArgb(95, 0, 0, 0), // 95 = şeffaflık
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
            label.Click += (s, e) =>
            {
                Kahvalti Kahvalti = new Kahvalti();
                Kahvalti.Show();
                this.Hide();

            };
            overlay.Controls.Add(label);
            pictureBox.Controls.Add(overlay);
         


        }
        private void trans_panel2(PictureBox pictureBox, string text)
        {
            // Yarı saydam panel oluştur
            Panel overlay = new Panel
            {
                BackColor = Color.FromArgb(95, 0, 0, 0), // 95 = şeffaflık
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
            label.Click += (s, e) =>
            {
                Atistirmalik Atistirmalik = new Atistirmalik();
                Atistirmalik.Show();
                this.Hide();

            };
            overlay.Controls.Add(label);
            pictureBox.Controls.Add(overlay);



        }
        private void trans_panel3(PictureBox pictureBox, string text)
        {
            // Yarı saydam panel oluştur
            Panel overlay = new Panel
            {
                BackColor = Color.FromArgb(95, 0, 0, 0), // 95 = şeffaflık
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
            label.Click += (s, e) =>
            {
                AnaYemek AnaYemek = new AnaYemek();
                AnaYemek.Show();
                this.Hide();

            };
            overlay.Controls.Add(label);
            pictureBox.Controls.Add(overlay);



        }
        private void trans_panel4(PictureBox pictureBox, string text)
        {
            // Yarı saydam panel oluştur
            Panel overlay = new Panel
            {
                BackColor = Color.FromArgb(95, 0, 0, 0), // 95 = şeffaflık
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
            label.Click += (s, e) =>
            {
               Tatli Tatli = new Tatli();
                Tatli.Show();
                this.Hide();

            };
            overlay.Controls.Add(label);
            pictureBox.Controls.Add(overlay);



        }
        private void trans_panel5(PictureBox pictureBox, string text)
        {
            // Yarı saydam panel oluştur
            Panel overlay = new Panel
            {
                BackColor = Color.FromArgb(95, 0, 0, 0), // 95 = şeffaflık
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
            label.Click += (s, e) =>
            {
                SicakIcecek SicakIcecek = new SicakIcecek();
                SicakIcecek.Show();
                this.Hide();

            };
            overlay.Controls.Add(label);
            pictureBox.Controls.Add(overlay);



        }
        private void trans_panel6(PictureBox pictureBox, string text)
        {
            // Yarı saydam panel oluştur
            Panel overlay = new Panel
            {
                BackColor = Color.FromArgb(95, 0, 0, 0), // 95 = şeffaflık
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
            label.Click += (s, e) =>
            {
                SogukIcecek SogukIcecek = new SogukIcecek();
                SogukIcecek.Show();
                this.Hide();

            };
            overlay.Controls.Add(label);
            pictureBox.Controls.Add(overlay);



        }







        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btn_grs_Click(object sender, EventArgs e)
        {
            AdminGiris AdminGiris = new AdminGiris(); 
            AdminGiris.Show();                    
            this.Hide();                            

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {


            // PictureBox üzerine ekle
            trans_panel1(khvlt_pic, "KAHVALTI");
            trans_panel2(atstr_pic, "ATIŞTIRMALIKLAR");
            trans_panel3(anaymk_pic, "ANA YEMEK");
            trans_panel4(tatli_pic, "TATLI");
            trans_panel5(sck_pic,"SICAK İÇECEKLER");
            trans_panel6(sgk_pic, "SOĞUK İÇECEKLER");
        }

        private void khvlt_pic_Click(object sender, EventArgs e)
        {
           
        }

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
