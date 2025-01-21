using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using otel_otomasyon.DOMAIN;
using otel_otomasyon.SERVİCE;

namespace otel_otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();


        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            {

                string dogruKullaniciAdi = "selim41";
                string dogruSifre = "1907";


                if (kullanıcıAdıTxt.Text == dogruKullaniciAdi && sifreTxt.Text == dogruSifre)
                {
                    MessageBox.Show("Başarılı giriş", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    anaEkran form2 = new anaEkran();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilgi yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }







            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();

        }


    }
}

