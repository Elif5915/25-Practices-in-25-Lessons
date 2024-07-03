namespace WordLearning
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
            this.lblİngilizce = new System.Windows.Forms.Label();
            this.txtİnglizce = new System.Windows.Forms.TextBox();
            this.lblTürkce = new System.Windows.Forms.Label();
            this.txtTürkce = new System.Windows.Forms.TextBox();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblsüreDegeri = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.lblkelimeSayısı = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblİngilizce
            // 
            this.lblİngilizce.AutoSize = true;
            this.lblİngilizce.Location = new System.Drawing.Point(74, 60);
            this.lblİngilizce.Name = "lblİngilizce";
            this.lblİngilizce.Size = new System.Drawing.Size(88, 25);
            this.lblİngilizce.TabIndex = 0;
            this.lblİngilizce.Text = "İngilizce:";
            // 
            // txtİnglizce
            // 
            this.txtİnglizce.Location = new System.Drawing.Point(193, 57);
            this.txtİnglizce.Name = "txtİnglizce";
            this.txtİnglizce.Size = new System.Drawing.Size(223, 30);
            this.txtİnglizce.TabIndex = 10;
            // 
            // lblTürkce
            // 
            this.lblTürkce.AutoSize = true;
            this.lblTürkce.Location = new System.Drawing.Point(74, 145);
            this.lblTürkce.Name = "lblTürkce";
            this.lblTürkce.Size = new System.Drawing.Size(79, 25);
            this.lblTürkce.TabIndex = 2;
            this.lblTürkce.Text = "Türkçe:";
            // 
            // txtTürkce
            // 
            this.txtTürkce.Location = new System.Drawing.Point(193, 142);
            this.txtTürkce.Name = "txtTürkce";
            this.txtTürkce.Size = new System.Drawing.Size(223, 30);
            this.txtTürkce.TabIndex = 1;
            this.txtTürkce.TextChanged += new System.EventHandler(this.txtTürkce_TextChanged);
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(527, 55);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(60, 25);
            this.lblSure.TabIndex = 4;
            this.lblSure.Text = "Süre:";
            // 
            // lblsüreDegeri
            // 
            this.lblsüreDegeri.AutoSize = true;
            this.lblsüreDegeri.Location = new System.Drawing.Point(641, 55);
            this.lblsüreDegeri.Name = "lblsüreDegeri";
            this.lblsüreDegeri.Size = new System.Drawing.Size(34, 25);
            this.lblsüreDegeri.TabIndex = 5;
            this.lblsüreDegeri.Text = "90";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Location = new System.Drawing.Point(527, 142);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(78, 25);
            this.lblKelime.TabIndex = 6;
            this.lblKelime.Text = "Kelime:";
            // 
            // lblkelimeSayısı
            // 
            this.lblkelimeSayısı.AutoSize = true;
            this.lblkelimeSayısı.Location = new System.Drawing.Point(641, 142);
            this.lblkelimeSayısı.Name = "lblkelimeSayısı";
            this.lblkelimeSayısı.Size = new System.Drawing.Size(23, 25);
            this.lblkelimeSayısı.TabIndex = 7;
            this.lblkelimeSayısı.Text = "0";
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(352, 188);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(64, 25);
            this.lblCevap.TabIndex = 8;
            this.lblCevap.Text = "label1";
            this.lblCevap.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 222);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.lblkelimeSayısı);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.lblsüreDegeri);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.txtTürkce);
            this.Controls.Add(this.lblTürkce);
            this.Controls.Add(this.txtİnglizce);
            this.Controls.Add(this.lblİngilizce);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblİngilizce;
        private System.Windows.Forms.TextBox txtİnglizce;
        private System.Windows.Forms.Label lblTürkce;
        private System.Windows.Forms.TextBox txtTürkce;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblsüreDegeri;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label lblkelimeSayısı;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Timer timer1;
    }
}

