namespace Ögrenci_Etüt_DersKayitSistemi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.txtSınıfı = new System.Windows.Forms.TextBox();
            this.txtOgrencıSoyad = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnOgrencıEkle = new System.Windows.Forms.Button();
            this.btnResimYukle = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sınıfı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon:";
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(175, 47);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(251, 30);
            this.txtOgrenciAd.TabIndex = 5;
            // 
            // txtSınıfı
            // 
            this.txtSınıfı.Location = new System.Drawing.Point(175, 165);
            this.txtSınıfı.Name = "txtSınıfı";
            this.txtSınıfı.Size = new System.Drawing.Size(251, 30);
            this.txtSınıfı.TabIndex = 6;
            // 
            // txtOgrencıSoyad
            // 
            this.txtOgrencıSoyad.Location = new System.Drawing.Point(175, 106);
            this.txtOgrencıSoyad.Name = "txtOgrencıSoyad";
            this.txtOgrencıSoyad.Size = new System.Drawing.Size(251, 30);
            this.txtOgrencıSoyad.TabIndex = 7;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(175, 278);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(251, 30);
            this.txtmail.TabIndex = 8;
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(175, 224);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(251, 30);
            this.mskTelefon.TabIndex = 9;
            // 
            // btnOgrencıEkle
            // 
            this.btnOgrencıEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOgrencıEkle.Location = new System.Drawing.Point(243, 333);
            this.btnOgrencıEkle.Name = "btnOgrencıEkle";
            this.btnOgrencıEkle.Size = new System.Drawing.Size(183, 42);
            this.btnOgrencıEkle.TabIndex = 10;
            this.btnOgrencıEkle.Text = "Öğrenci Ekle";
            this.btnOgrencıEkle.UseVisualStyleBackColor = false;
            this.btnOgrencıEkle.Click += new System.EventHandler(this.btnOgrencıEkle_Click);
            // 
            // btnResimYukle
            // 
            this.btnResimYukle.BackColor = System.Drawing.Color.Cyan;
            this.btnResimYukle.Location = new System.Drawing.Point(484, 278);
            this.btnResimYukle.Name = "btnResimYukle";
            this.btnResimYukle.Size = new System.Drawing.Size(209, 36);
            this.btnResimYukle.TabIndex = 11;
            this.btnResimYukle.Text = "Resim Yükle";
            this.btnResimYukle.UseVisualStyleBackColor = false;
            this.btnResimYukle.Click += new System.EventHandler(this.btnResimYukle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(484, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 207);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(726, 406);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnResimYukle);
            this.Controls.Add(this.btnOgrencıEkle);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtOgrencıSoyad);
            this.Controls.Add(this.txtSınıfı);
            this.Controls.Add(this.txtOgrenciAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Öğrenci Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.TextBox txtSınıfı;
        private System.Windows.Forms.TextBox txtOgrencıSoyad;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Button btnOgrencıEkle;
        private System.Windows.Forms.Button btnResimYukle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}