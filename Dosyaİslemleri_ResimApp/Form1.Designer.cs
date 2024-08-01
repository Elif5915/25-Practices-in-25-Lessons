namespace Dosyaİslemleri_ResimApp
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
            this.btnrenksec = new System.Windows.Forms.Button();
            this.btnresimsec = new System.Windows.Forms.Button();
            this.btnyazdır = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMetinGir = new System.Windows.Forms.TextBox();
            this.txtBoyutGir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnrenksec
            // 
            this.btnrenksec.Location = new System.Drawing.Point(51, 122);
            this.btnrenksec.Name = "btnrenksec";
            this.btnrenksec.Size = new System.Drawing.Size(247, 45);
            this.btnrenksec.TabIndex = 3;
            this.btnrenksec.Text = "Renk Seç";
            this.btnrenksec.UseVisualStyleBackColor = true;
            this.btnrenksec.Click += new System.EventHandler(this.btnrenksec_Click);
            // 
            // btnresimsec
            // 
            this.btnresimsec.Location = new System.Drawing.Point(51, 55);
            this.btnresimsec.Name = "btnresimsec";
            this.btnresimsec.Size = new System.Drawing.Size(247, 45);
            this.btnresimsec.TabIndex = 1;
            this.btnresimsec.Text = "Resim Seç";
            this.btnresimsec.UseVisualStyleBackColor = true;
            this.btnresimsec.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnyazdır
            // 
            this.btnyazdır.Location = new System.Drawing.Point(51, 185);
            this.btnyazdır.Name = "btnyazdır";
            this.btnyazdır.Size = new System.Drawing.Size(247, 45);
            this.btnyazdır.TabIndex = 2;
            this.btnyazdır.Text = "Yazdır";
            this.btnyazdır.UseVisualStyleBackColor = true;
            this.btnyazdır.Click += new System.EventHandler(this.btnyazdır_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(51, 249);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(247, 45);
            this.btnkaydet.TabIndex = 4;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metin";
            // 
            // txtMetinGir
            // 
            this.txtMetinGir.Location = new System.Drawing.Point(114, 334);
            this.txtMetinGir.Name = "txtMetinGir";
            this.txtMetinGir.Size = new System.Drawing.Size(184, 29);
            this.txtMetinGir.TabIndex = 5;
            // 
            // txtBoyutGir
            // 
            this.txtBoyutGir.Location = new System.Drawing.Point(114, 379);
            this.txtBoyutGir.Name = "txtBoyutGir";
            this.txtBoyutGir.Size = new System.Drawing.Size(184, 29);
            this.txtBoyutGir.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Boyut";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(357, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(697, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnkaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1105, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoyutGir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMetinGir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyazdır);
            this.Controls.Add(this.btnresimsec);
            this.Controls.Add(this.btnrenksec);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dosya İşlemleri ile Resim Üzerine Yazı Yazma Uygulaması ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrenksec;
        private System.Windows.Forms.Button btnresimsec;
        private System.Windows.Forms.Button btnyazdır;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMetinGir;
        private System.Windows.Forms.TextBox txtBoyutGir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

