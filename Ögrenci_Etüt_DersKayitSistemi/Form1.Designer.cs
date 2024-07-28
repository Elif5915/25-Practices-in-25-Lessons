namespace Ögrenci_Etüt_DersKayitSistemi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.cmboxOgretmen = new System.Windows.Forms.ComboBox();
            this.lblOgretmen = new System.Windows.Forms.Label();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.cmboxDers = new System.Windows.Forms.ComboBox();
            this.lblDers = new System.Windows.Forms.Label();
            this.lnkOgretmenEkle = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciNumarasi = new System.Windows.Forms.TextBox();
            this.btnEtutVer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lnkOgrenciEkle = new System.Windows.Forms.LinkLabel();
            this.lnkDersEkle = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOlustur);
            this.groupBox1.Controls.Add(this.lblSaat);
            this.groupBox1.Controls.Add(this.lblTarih);
            this.groupBox1.Controls.Add(this.mskSaat);
            this.groupBox1.Controls.Add(this.cmboxOgretmen);
            this.groupBox1.Controls.Add(this.lblOgretmen);
            this.groupBox1.Controls.Add(this.msktarih);
            this.groupBox1.Controls.Add(this.cmboxDers);
            this.groupBox1.Controls.Add(this.lblDers);
            this.groupBox1.Location = new System.Drawing.Point(38, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etüt Oluşturma";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(180, 233);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(245, 44);
            this.btnOlustur.TabIndex = 8;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(79, 194);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(64, 24);
            this.lblSaat.TabIndex = 7;
            this.lblSaat.Text = "Saat:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(67, 148);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(76, 24);
            this.lblTarih.TabIndex = 6;
            this.lblTarih.Text = "Tarih:";
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(180, 188);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(245, 30);
            this.mskSaat.TabIndex = 4;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // cmboxOgretmen
            // 
            this.cmboxOgretmen.FormattingEnabled = true;
            this.cmboxOgretmen.Location = new System.Drawing.Point(180, 93);
            this.cmboxOgretmen.Name = "cmboxOgretmen";
            this.cmboxOgretmen.Size = new System.Drawing.Size(245, 32);
            this.cmboxOgretmen.TabIndex = 2;
            // 
            // lblOgretmen
            // 
            this.lblOgretmen.AutoSize = true;
            this.lblOgretmen.Location = new System.Drawing.Point(22, 96);
            this.lblOgretmen.Name = "lblOgretmen";
            this.lblOgretmen.Size = new System.Drawing.Size(121, 24);
            this.lblOgretmen.TabIndex = 3;
            this.lblOgretmen.Text = "Öğretmen:";
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(180, 142);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(245, 30);
            this.msktarih.TabIndex = 3;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmboxDers
            // 
            this.cmboxDers.FormattingEnabled = true;
            this.cmboxDers.Location = new System.Drawing.Point(180, 44);
            this.cmboxDers.Name = "cmboxDers";
            this.cmboxDers.Size = new System.Drawing.Size(245, 32);
            this.cmboxDers.TabIndex = 1;
            this.cmboxDers.SelectedIndexChanged += new System.EventHandler(this.cmboxDers_SelectedIndexChanged);
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.Location = new System.Drawing.Point(77, 47);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(66, 24);
            this.lblDers.TabIndex = 0;
            this.lblDers.Text = "Ders:";
            // 
            // lnkOgretmenEkle
            // 
            this.lnkOgretmenEkle.AutoSize = true;
            this.lnkOgretmenEkle.Location = new System.Drawing.Point(513, 293);
            this.lnkOgretmenEkle.Name = "lnkOgretmenEkle";
            this.lnkOgretmenEkle.Size = new System.Drawing.Size(164, 24);
            this.lnkOgretmenEkle.TabIndex = 9;
            this.lnkOgretmenEkle.TabStop = true;
            this.lnkOgretmenEkle.Text = "Öğretmen Ekle";
            this.lnkOgretmenEkle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lnkOgretmenEkle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOgretmenEkle_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtOgrenciNumarasi);
            this.groupBox2.Controls.Add(this.btnEtutVer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(515, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etüt Kayıt";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(160, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 30);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Etüt İd:";
            // 
            // txtOgrenciNumarasi
            // 
            this.txtOgrenciNumarasi.Location = new System.Drawing.Point(160, 90);
            this.txtOgrenciNumarasi.Name = "txtOgrenciNumarasi";
            this.txtOgrenciNumarasi.Size = new System.Drawing.Size(190, 30);
            this.txtOgrenciNumarasi.TabIndex = 5;
            // 
            // btnEtutVer
            // 
            this.btnEtutVer.Location = new System.Drawing.Point(160, 146);
            this.btnEtutVer.Name = "btnEtutVer";
            this.btnEtutVer.Size = new System.Drawing.Size(194, 38);
            this.btnEtutVer.TabIndex = 4;
            this.btnEtutVer.Text = "Etüte Kayıt Et";
            this.btnEtutVer.UseVisualStyleBackColor = true;
            this.btnEtutVer.Click += new System.EventHandler(this.btnEtutVer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(38, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(925, 266);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(919, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lnkOgrenciEkle
            // 
            this.lnkOgrenciEkle.AutoSize = true;
            this.lnkOgrenciEkle.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnkOgrenciEkle.Location = new System.Drawing.Point(696, 293);
            this.lnkOgrenciEkle.Name = "lnkOgrenciEkle";
            this.lnkOgrenciEkle.Size = new System.Drawing.Size(143, 24);
            this.lnkOgrenciEkle.TabIndex = 10;
            this.lnkOgrenciEkle.TabStop = true;
            this.lnkOgrenciEkle.Text = "Öğrenci Ekle";
            this.lnkOgrenciEkle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOgrenciEkle_LinkClicked);
            // 
            // lnkDersEkle
            // 
            this.lnkDersEkle.AutoSize = true;
            this.lnkDersEkle.LinkColor = System.Drawing.Color.Fuchsia;
            this.lnkDersEkle.Location = new System.Drawing.Point(854, 293);
            this.lnkDersEkle.Name = "lnkDersEkle";
            this.lnkDersEkle.Size = new System.Drawing.Size(109, 24);
            this.lnkDersEkle.TabIndex = 11;
            this.lnkDersEkle.TabStop = true;
            this.lnkDersEkle.Text = "Ders Ekle";
            this.lnkDersEkle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDersEkle_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(987, 641);
            this.Controls.Add(this.lnkDersEkle);
            this.Controls.Add(this.lnkOgrenciEkle);
            this.Controls.Add(this.lnkOgretmenEkle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOgretmen;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.ComboBox cmboxDers;
        private System.Windows.Forms.Label lblDers;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.ComboBox cmboxOgretmen;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEtutVer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel lnkOgretmenEkle;
        private System.Windows.Forms.TextBox txtOgrenciNumarasi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkOgrenciEkle;
        private System.Windows.Forms.LinkLabel lnkDersEkle;
    }
}

