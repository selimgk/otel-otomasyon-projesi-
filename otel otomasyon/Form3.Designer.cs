namespace otel_otomasyon
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.isimTxt = new System.Windows.Forms.TextBox();
            this.soyisimTxt = new System.Windows.Forms.TextBox();
            this.tckimliknoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.çıkıştarihiTxt = new System.Windows.Forms.DateTimePicker();
            this.giriştarihiTxt = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.rzvnotxt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // isimTxt
            // 
            this.isimTxt.BackColor = System.Drawing.Color.White;
            this.isimTxt.Location = new System.Drawing.Point(-1, 25);
            this.isimTxt.Name = "isimTxt";
            this.isimTxt.Size = new System.Drawing.Size(254, 26);
            this.isimTxt.TabIndex = 0;
            // 
            // soyisimTxt
            // 
            this.soyisimTxt.Location = new System.Drawing.Point(-1, 25);
            this.soyisimTxt.Name = "soyisimTxt";
            this.soyisimTxt.Size = new System.Drawing.Size(254, 26);
            this.soyisimTxt.TabIndex = 1;
            // 
            // tckimliknoTxt
            // 
            this.tckimliknoTxt.Location = new System.Drawing.Point(-2, 21);
            this.tckimliknoTxt.Name = "tckimliknoTxt";
            this.tckimliknoTxt.Size = new System.Drawing.Size(257, 26);
            this.tckimliknoTxt.TabIndex = 2;
            this.tckimliknoTxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 6;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.Location = new System.Drawing.Point(679, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 77);
            this.button1.TabIndex = 21;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Olive;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button2.Location = new System.Drawing.Point(679, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 77);
            this.button2.TabIndex = 27;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.isimTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.Location = new System.Drawing.Point(34, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 52);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İsim";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gold;
            this.groupBox2.Controls.Add(this.soyisimTxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox2.Location = new System.Drawing.Point(33, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 52);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Soyisim";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gold;
            this.groupBox3.Controls.Add(this.tckimliknoTxt);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox3.Location = new System.Drawing.Point(31, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 48);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tc Kimlik No";
            // 
            // çıkıştarihiTxt
            // 
            this.çıkıştarihiTxt.Location = new System.Drawing.Point(0, 25);
            this.çıkıştarihiTxt.Name = "çıkıştarihiTxt";
            this.çıkıştarihiTxt.Size = new System.Drawing.Size(257, 26);
            this.çıkıştarihiTxt.TabIndex = 33;
            // 
            // giriştarihiTxt
            // 
            this.giriştarihiTxt.Location = new System.Drawing.Point(0, 25);
            this.giriştarihiTxt.Name = "giriştarihiTxt";
            this.giriştarihiTxt.Size = new System.Drawing.Size(257, 26);
            this.giriştarihiTxt.TabIndex = 34;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Gold;
            this.groupBox6.Controls.Add(this.giriştarihiTxt);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox6.Location = new System.Drawing.Point(352, 53);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(257, 50);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Giriş Tarihi";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Gold;
            this.groupBox7.Controls.Add(this.çıkıştarihiTxt);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox7.Location = new System.Drawing.Point(352, 152);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(257, 52);
            this.groupBox7.TabIndex = 36;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Çıkış Tarihi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1175, 351);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button3.Location = new System.Drawing.Point(679, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(293, 77);
            this.button3.TabIndex = 38;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1038, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 73);
            this.button4.TabIndex = 41;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rzvnotxt
            // 
            this.rzvnotxt.Location = new System.Drawing.Point(1166, 214);
            this.rzvnotxt.Name = "rzvnotxt";
            this.rzvnotxt.Size = new System.Drawing.Size(10, 22);
            this.rzvnotxt.TabIndex = 0;
            this.rzvnotxt.TextChanged += new System.EventHandler(this.rzvnotxt_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Gold;
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox5.Location = new System.Drawing.Point(1, 276);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1181, 382);
            this.groupBox5.TabIndex = 43;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rezervasyon Tablosu";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1180, 658);
            this.Controls.Add(this.rzvnotxt);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Rezervasyon Ekranı";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isimTxt;
        private System.Windows.Forms.TextBox soyisimTxt;
        private System.Windows.Forms.TextBox tckimliknoTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker çıkıştarihiTxt;
        private System.Windows.Forms.DateTimePicker giriştarihiTxt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.TextBox rzvnotxt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
    }
}