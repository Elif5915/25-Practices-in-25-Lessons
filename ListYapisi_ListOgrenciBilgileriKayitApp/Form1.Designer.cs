namespace ListYapisi_ListOgrenciBilgileriKayitApp
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
            this.btnList1 = new System.Windows.Forms.Button();
            this.btnList2 = new System.Windows.Forms.Button();
            this.btnList3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnList1
            // 
            this.btnList1.Location = new System.Drawing.Point(23, 493);
            this.btnList1.Name = "btnList1";
            this.btnList1.Size = new System.Drawing.Size(279, 43);
            this.btnList1.TabIndex = 0;
            this.btnList1.Text = "Listele 1";
            this.btnList1.UseVisualStyleBackColor = true;
            this.btnList1.Click += new System.EventHandler(this.btnList1_Click);
            // 
            // btnList2
            // 
            this.btnList2.Location = new System.Drawing.Point(359, 493);
            this.btnList2.Name = "btnList2";
            this.btnList2.Size = new System.Drawing.Size(279, 43);
            this.btnList2.TabIndex = 1;
            this.btnList2.Text = "Listele 2";
            this.btnList2.UseVisualStyleBackColor = true;
            this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
            // 
            // btnList3
            // 
            this.btnList3.Location = new System.Drawing.Point(696, 493);
            this.btnList3.Name = "btnList3";
            this.btnList3.Size = new System.Drawing.Size(279, 43);
            this.btnList3.TabIndex = 2;
            this.btnList3.Text = "Listele 3";
            this.btnList3.UseVisualStyleBackColor = true;
            this.btnList3.Click += new System.EventHandler(this.btnList3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(23, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 436);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(359, 32);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(279, 436);
            this.listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 24;
            this.listBox3.Location = new System.Drawing.Point(696, 32);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(279, 436);
            this.listBox3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1008, 557);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnList3);
            this.Controls.Add(this.btnList2);
            this.Controls.Add(this.btnList1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "List Yapısı ve List Öğrenci Bilgileri Kayıt Sistemi  ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList1;
        private System.Windows.Forms.Button btnList2;
        private System.Windows.Forms.Button btnList3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}

