using MySql.Data.MySqlClient;
using otel_otomasyon.DAL;
using otel_otomasyon.SERVİCE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace otel_otomasyon
{
    public partial class Form4 : Form
    {

        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataAdapter da;
        public Form4()
        {
            InitializeComponent();
        }

        void odagetir()
        {
            baglanti = new MySqlConnection("Server=172.21.54.253; Database=25_132330016; User=25_132330016; Password=!nif.ogr16GO;");
            baglanti.Open();
            da = new MySqlDataAdapter("SELECT *FROM tbl_odalar", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
            



        }

        public void button1_Click(object sender, EventArgs e)
        {
            {
               
                string kontrolSorgu = "SELECT COUNT(*) FROM tbl_odalar WHERE OdaNumarası = @OdaNumarası";
                komut = new MySqlCommand(kontrolSorgu, baglanti);
                komut.Parameters.AddWithValue("@OdaNumarası", odanumarasıtxt.Text);

                baglanti.Open();
                int odaVarMi = Convert.ToInt32(komut.ExecuteScalar());
                baglanti.Close();

                if (odaVarMi > 0)
                {
                    MessageBox.Show("Bu oda numarası zaten mevcut. Lütfen farklı bir oda numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sorgu = "INSERT INTO tbl_odalar(OdaFiyatı, OdaTipi, OdaNumarası, OdaDurumu) VALUES (@OdaFiyatı, @OdaTipi, @OdaNumarası, @OdaDurumu)";
                    komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@OdaFiyatı", odafiyatıtxt.Text);
                    komut.Parameters.AddWithValue("@OdaTipi", odatipitxt.Text);
                    komut.Parameters.AddWithValue("@OdaNumarası", odanumarasıtxt.Text);
                    komut.Parameters.AddWithValue("@OdaDurumu", odadurumutxt.Text);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    odagetir();
                    MessageBox.Show("Oda başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }



        }

        

        public void button2_Click(object sender, EventArgs e)
        {
           string sorgu = "DELETE FROM tbl_odalar WHERE oda_id=@oda_id";
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@oda_id", Convert.ToInt32(odasıratxt.Text));
            baglanti.Open();
            komut.ExecuteReader();
            baglanti.Close();
            odagetir(); 





        }

        public void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            odasıratxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            odafiyatıtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            odatipitxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            odanumarasıtxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            odadurumutxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        public void btngüncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE tbl_odalar SET OdaFiyatı=@OdaFiyatı, OdaTipi=@OdaTipi, OdaNumarası=@OdaNumarası,OdaDurumu=@OdaDurumu WHERE oda_id=@oda_id";
            komut = new MySqlCommand(sorgu ,baglanti);
            komut.Parameters.AddWithValue("@oda_id", Convert.ToInt32(odasıratxt.Text));
            komut.Parameters.AddWithValue("@OdaFiyatı",(odafiyatıtxt.Text));
            komut.Parameters.AddWithValue("@OdaTipi", odatipitxt.Text);
            komut.Parameters.AddWithValue("@OdaNumarası", odanumarasıtxt.Text);
            komut.Parameters.AddWithValue("@OdaDurumu", odadurumutxt.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            odagetir();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            odasıratxt.Visible = false;
        }

        public void Form4_Load(object sender, EventArgs e)
        {
            odagetir();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
            this.Hide();
        }
    }
}