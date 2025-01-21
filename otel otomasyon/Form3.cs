using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using otel_otomasyon.DOMAIN;
using otel_otomasyon.SERVİCE;
using System.Collections;
using MySql.Data.MySqlClient;

namespace otel_otomasyon
{
    public partial class Form3 : Form
    {

        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataAdapter da;


        public Form3()
        {
            InitializeComponent();
        }

        void rezervasyongetir()
        {
            baglanti = new MySqlConnection("Server=172.21.54.253; Database=25_132330016; User=25_132330016; Password=!nif.ogr16GO;");
            baglanti.Open();
            da = new MySqlDataAdapter("SELECT *FROM tbl_rezervasyon", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            anaEkran fr = new anaEkran();
            fr.Show();
            this.Close();
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            rezervasyongetir();

            

        }
        

        public void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO tbl_rezervasyon(İsim,Soyisim,Tckimlikno,GirişTarihi,ÇıkışTarihi) VALUES (@İsim,@Soyisim,@Tckimlikno,@GirişTarihi,@ÇıkışTarihi)";
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@İsim", isimTxt.Text);
            komut.Parameters.AddWithValue("@Soyisim", soyisimTxt.Text);
            komut.Parameters.AddWithValue("@Tckimlikno", tckimliknoTxt.Text);
            komut.Parameters.AddWithValue("@GirişTarihi", giriştarihiTxt.Text);
            komut.Parameters.AddWithValue("@ÇıkışTarihi", çıkıştarihiTxt.Text);
            baglanti.Open();
            komut.ExecuteReader();
            baglanti.Close();
            rezervasyongetir();











        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string sorgu = "UPDATE tbl_rezervasyon SET İsim=@İsim, Soyisim=@Soyisim, Tckimlikno=@Tckimlikno,GirişTarihi=@GirişTarihi,ÇıkışTarihi=@ÇıkışTarihi WHERE rezervasyon_id=@rezervasyon_id";
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@rezervasyon_id", Convert.ToInt32(rzvnotxt.Text));
            komut.Parameters.AddWithValue("@İsim",(isimTxt.Text));
            komut.Parameters.AddWithValue("@Soyisim", soyisimTxt.Text);
            komut.Parameters.AddWithValue("@Tckimlikno", tckimliknoTxt.Text);
            komut.Parameters.AddWithValue("@GirişTarihi", giriştarihiTxt.Text);
            komut.Parameters.AddWithValue("@ÇıkışTarihi", çıkıştarihiTxt.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            rezervasyongetir();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM tbl_rezervasyon WHERE rezervasyon_id=@rezervasyon_id";
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@rezervasyon_id", Convert.ToInt32(rzvnotxt.Text));
            baglanti.Open();
            komut.ExecuteReader();
            baglanti.Close();
            rezervasyongetir();

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            anaEkran fr = new anaEkran();
            fr.Show();
            this.Close();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rzvnotxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            isimTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyisimTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tckimliknoTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            giriştarihiTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            çıkıştarihiTxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void rzvnotxt_TextChanged(object sender, EventArgs e)
        {
            rzvnotxt.Visible = false;
        }
    }
}
