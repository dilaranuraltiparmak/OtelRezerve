namespace Hotel.UI
{
    partial class FormOdeme
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.btnExtraEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYeniUcret = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dtCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblcikis = new System.Windows.Forms.Label();
            this.btnTutar = new System.Windows.Forms.Button();
            this.btnUcretOde = new System.Windows.Forms.Button();
            this.btnGec = new System.Windows.Forms.Button();
            this.btnOnceki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Seç";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(96, 48);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(121, 21);
            this.cmbMusteri.TabIndex = 1;
            this.cmbMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbMusteri_SelectedIndexChanged);
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(12, 77);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(0, 15);
            this.lblBilgi.TabIndex = 2;
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(12, 103);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(0, 13);
            this.lblUcret.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Tag = "25";
            this.checkBox1.Text = "Kuruyemiş";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(83, 194);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Tag = "15";
            this.checkBox2.Text = "Çikolata";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 217);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(43, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Tag = "255";
            this.checkBox3.Text = "İçki";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(83, 217);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(70, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Tag = "18";
            this.checkBox4.Text = "İçecekler";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(153, 194);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(71, 17);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Tag = "8";
            this.checkBox5.Text = "Bisküviler";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // btnExtraEkle
            // 
            this.btnExtraEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExtraEkle.Location = new System.Drawing.Point(129, 250);
            this.btnExtraEkle.Name = "btnExtraEkle";
            this.btnExtraEkle.Size = new System.Drawing.Size(65, 30);
            this.btnExtraEkle.TabIndex = 9;
            this.btnExtraEkle.Text = "Extra Ekle";
            this.btnExtraEkle.UseVisualStyleBackColor = true;
            this.btnExtraEkle.Click += new System.EventHandler(this.btnExtraEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Yeni Ücret : ";
            // 
            // lblYeniUcret
            // 
            this.lblYeniUcret.AutoSize = true;
            this.lblYeniUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniUcret.Location = new System.Drawing.Point(103, 364);
            this.lblYeniUcret.Name = "lblYeniUcret";
            this.lblYeniUcret.Size = new System.Drawing.Size(0, 16);
            this.lblYeniUcret.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(2, 257);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // dtCikisTarihi
            // 
            this.dtCikisTarihi.Location = new System.Drawing.Point(63, 144);
            this.dtCikisTarihi.Name = "dtCikisTarihi";
            this.dtCikisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtCikisTarihi.TabIndex = 13;
            this.dtCikisTarihi.ValueChanged += new System.EventHandler(this.dtCikisTarihi_ValueChanged);
            // 
            // lblcikis
            // 
            this.lblcikis.AutoSize = true;
            this.lblcikis.Location = new System.Drawing.Point(-1, 150);
            this.lblcikis.Name = "lblcikis";
            this.lblcikis.Size = new System.Drawing.Size(58, 13);
            this.lblcikis.TabIndex = 14;
            this.lblcikis.Text = "Çıkış Tarihi";
            // 
            // btnTutar
            // 
            this.btnTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTutar.Location = new System.Drawing.Point(45, 296);
            this.btnTutar.Name = "btnTutar";
            this.btnTutar.Size = new System.Drawing.Size(86, 27);
            this.btnTutar.TabIndex = 15;
            this.btnTutar.Text = "Tutar";
            this.btnTutar.UseVisualStyleBackColor = true;
            this.btnTutar.Click += new System.EventHandler(this.btnTutar_Click);
            // 
            // btnUcretOde
            // 
            this.btnUcretOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcretOde.Location = new System.Drawing.Point(106, 430);
            this.btnUcretOde.Name = "btnUcretOde";
            this.btnUcretOde.Size = new System.Drawing.Size(143, 53);
            this.btnUcretOde.TabIndex = 16;
            this.btnUcretOde.Text = "Ücreti Öde";
            this.btnUcretOde.UseVisualStyleBackColor = true;
            this.btnUcretOde.Click += new System.EventHandler(this.btnUcretOde_Click);
            // 
            // btnGec
            // 
            this.btnGec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGec.Location = new System.Drawing.Point(279, 430);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(91, 53);
            this.btnGec.TabIndex = 17;
            this.btnGec.Text = "Geç";
            this.btnGec.UseVisualStyleBackColor = true;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // btnOnceki
            // 
            this.btnOnceki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnceki.Location = new System.Drawing.Point(15, 430);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(75, 53);
            this.btnOnceki.TabIndex = 18;
            this.btnOnceki.Text = "<<";
            this.btnOnceki.UseVisualStyleBackColor = true;
            this.btnOnceki.Click += new System.EventHandler(this.btnOnceki_Click);
            // 
            // FormOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(449, 561);
            this.Controls.Add(this.btnOnceki);
            this.Controls.Add(this.btnGec);
            this.Controls.Add(this.btnUcretOde);
            this.Controls.Add(this.btnTutar);
            this.Controls.Add(this.lblcikis);
            this.Controls.Add(this.dtCikisTarihi);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblYeniUcret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExtraEkle);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.label1);
            this.Name = "FormOdeme";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button btnExtraEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYeniUcret;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dtCikisTarihi;
        private System.Windows.Forms.Label lblcikis;
        private System.Windows.Forms.Button btnTutar;
        private System.Windows.Forms.Button btnUcretOde;
        private System.Windows.Forms.Button btnGec;
        private System.Windows.Forms.Button btnOnceki;
    }
}