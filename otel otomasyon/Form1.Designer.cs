namespace otel_otomasyon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kullanıcıAdıTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullanıcıAdıTxt
            // 
            this.kullanıcıAdıTxt.BackColor = System.Drawing.Color.White;
            this.kullanıcıAdıTxt.ForeColor = System.Drawing.Color.Black;
            this.kullanıcıAdıTxt.Location = new System.Drawing.Point(0, 35);
            this.kullanıcıAdıTxt.Name = "kullanıcıAdıTxt";
            this.kullanıcıAdıTxt.Size = new System.Drawing.Size(200, 36);
            this.kullanıcıAdıTxt.TabIndex = 0;
            // 
            // sifreTxt
            // 
            this.sifreTxt.BackColor = System.Drawing.Color.White;
            this.sifreTxt.ForeColor = System.Drawing.Color.Black;
            this.sifreTxt.Location = new System.Drawing.Point(-1, 31);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(200, 36);
            this.sifreTxt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(277, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 86);
            this.button1.TabIndex = 4;
            this.button1.Text = "GİRİŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Gold;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(26, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(471, 88);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Emniyet Otel";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.kullanıcıAdıTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.Location = new System.Drawing.Point(36, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gold;
            this.groupBox2.Controls.Add(this.sifreTxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox2.Location = new System.Drawing.Point(36, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 67);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(536, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "tarih ve saat";
            
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullanıcıAdıTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

