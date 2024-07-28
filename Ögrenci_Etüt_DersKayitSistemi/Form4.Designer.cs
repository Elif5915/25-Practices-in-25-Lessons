namespace Ögrenci_Etüt_DersKayitSistemi
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
            this.lblDersAdi = new System.Windows.Forms.Label();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.txtYeniDers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.AutoSize = true;
            this.lblDersAdi.Location = new System.Drawing.Point(34, 45);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(105, 24);
            this.lblDersAdi.TabIndex = 0;
            this.lblDersAdi.Text = "Ders Adı:";
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDersEkle.Location = new System.Drawing.Point(397, 94);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(252, 39);
            this.btnDersEkle.TabIndex = 1;
            this.btnDersEkle.Text = "Dersi Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = false;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // txtYeniDers
            // 
            this.txtYeniDers.Location = new System.Drawing.Point(154, 39);
            this.txtYeniDers.Name = "txtYeniDers";
            this.txtYeniDers.Size = new System.Drawing.Size(495, 30);
            this.txtYeniDers.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(722, 170);
            this.Controls.Add(this.txtYeniDers);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.lblDersAdi);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Ders Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.TextBox txtYeniDers;
    }
}