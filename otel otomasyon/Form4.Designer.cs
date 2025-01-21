namespace otel_otomasyon
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.odafiyatıtxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.odatipitxt = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.odanumarasıtxt = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.odadurumutxt = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.odasıratxt = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // odafiyatıtxt
            // 
            this.odafiyatıtxt.Location = new System.Drawing.Point(0, 29);
            this.odafiyatıtxt.Name = "odafiyatıtxt";
            this.odafiyatıtxt.Size = new System.Drawing.Size(206, 30);
            this.odafiyatıtxt.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.odafiyatıtxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.Location = new System.Drawing.Point(22, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 58);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oda Fiyatı";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gold;
            this.groupBox2.Controls.Add(this.odatipitxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox2.Location = new System.Drawing.Point(22, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oda Tipi";
            // 
            // odatipitxt
            // 
            this.odatipitxt.FormattingEnabled = true;
            this.odatipitxt.Items.AddRange(new object[] {
            "Tek Kişilik",
            "Çift Kişilik",
            "Suit Oda"});
            this.odatipitxt.Location = new System.Drawing.Point(0, 29);
            this.odatipitxt.Name = "odatipitxt";
            this.odatipitxt.Size = new System.Drawing.Size(206, 33);
            this.odatipitxt.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gold;
            this.groupBox3.Controls.Add(this.odanumarasıtxt);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox3.Location = new System.Drawing.Point(278, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 61);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oda Numara";
            // 
            // odanumarasıtxt
            // 
            this.odanumarasıtxt.FormattingEnabled = true;
            this.odanumarasıtxt.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "201",
            "202",
            "203",
            "204",
            "205"});
            this.odanumarasıtxt.Location = new System.Drawing.Point(0, 28);
            this.odanumarasıtxt.Name = "odanumarasıtxt";
            this.odanumarasıtxt.Size = new System.Drawing.Size(206, 33);
            this.odanumarasıtxt.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gold;
            this.groupBox4.Controls.Add(this.odadurumutxt);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox4.Location = new System.Drawing.Point(278, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 58);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Oda Durumu";
            // 
            // odadurumutxt
            // 
            this.odadurumutxt.FormattingEnabled = true;
            this.odadurumutxt.Items.AddRange(new object[] {
            "Boş",
            "Dolu"});
            this.odadurumutxt.Location = new System.Drawing.Point(0, 25);
            this.odadurumutxt.Name = "odadurumutxt";
            this.odadurumutxt.Size = new System.Drawing.Size(206, 33);
            this.odadurumutxt.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(873, 303);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Yellow;
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnkaydet.Location = new System.Drawing.Point(527, 179);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(182, 59);
            this.btnkaydet.TabIndex = 8;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnsil.Location = new System.Drawing.Point(527, 105);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(182, 59);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.Olive;
            this.btngüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btngüncelle.Location = new System.Drawing.Point(527, 27);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(182, 59);
            this.btngüncelle.TabIndex = 10;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // odasıratxt
            // 
            this.odasıratxt.Location = new System.Drawing.Point(808, 216);
            this.odasıratxt.Name = "odasıratxt";
            this.odasıratxt.Size = new System.Drawing.Size(12, 22);
            this.odasıratxt.TabIndex = 11;
            this.odasıratxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Gold;
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox6.Location = new System.Drawing.Point(7, 287);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(873, 324);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Odalar Tablosu";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(784, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 59);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(880, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.odasıratxt);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Oda Kayıt";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox odafiyatıtxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox odatipitxt;
        private System.Windows.Forms.ComboBox odanumarasıtxt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.ComboBox odadurumutxt;
        private System.Windows.Forms.TextBox odasıratxt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
    }
}