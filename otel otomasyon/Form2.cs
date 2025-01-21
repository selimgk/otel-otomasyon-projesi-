using Mysqlx.Notice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otel_otomasyon
{
    public partial class anaEkran : Form
    {
        public anaEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
