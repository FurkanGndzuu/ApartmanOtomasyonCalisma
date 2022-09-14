namespace ApartmanOtomasyonCalisma
{
    partial class BinaGelirleri
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
            this.gelirBox = new System.Windows.Forms.GroupBox();
            this.btnGelirEkle = new System.Windows.Forms.Button();
            this.dateTarihPicker = new System.Windows.Forms.DateTimePicker();
            this.txtParaMiktari = new System.Windows.Forms.TextBox();
            this.cmbDaireNo = new System.Windows.Forms.ComboBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblParaMiktarı = new System.Windows.Forms.Label();
            this.lblDaireNo = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.gelirBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gelirBox
            // 
            this.gelirBox.Controls.Add(this.btnGelirEkle);
            this.gelirBox.Controls.Add(this.dateTarihPicker);
            this.gelirBox.Controls.Add(this.txtParaMiktari);
            this.gelirBox.Controls.Add(this.cmbDaireNo);
            this.gelirBox.Controls.Add(this.lblTarih);
            this.gelirBox.Controls.Add(this.lblParaMiktarı);
            this.gelirBox.Controls.Add(this.lblDaireNo);
            this.gelirBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelirBox.Location = new System.Drawing.Point(44, 32);
            this.gelirBox.Name = "gelirBox";
            this.gelirBox.Size = new System.Drawing.Size(870, 257);
            this.gelirBox.TabIndex = 0;
            this.gelirBox.TabStop = false;
            this.gelirBox.Text = "Gelir Ekle";
            // 
            // btnGelirEkle
            // 
            this.btnGelirEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGelirEkle.Location = new System.Drawing.Point(540, 111);
            this.btnGelirEkle.Name = "btnGelirEkle";
            this.btnGelirEkle.Size = new System.Drawing.Size(302, 57);
            this.btnGelirEkle.TabIndex = 6;
            this.btnGelirEkle.Text = "Ekle";
            this.btnGelirEkle.UseVisualStyleBackColor = false;
            this.btnGelirEkle.Click += new System.EventHandler(this.btnGelirEkle_Click);
            // 
            // dateTarihPicker
            // 
            this.dateTarihPicker.Location = new System.Drawing.Point(556, 44);
            this.dateTarihPicker.Name = "dateTarihPicker";
            this.dateTarihPicker.Size = new System.Drawing.Size(287, 34);
            this.dateTarihPicker.TabIndex = 5;
            // 
            // txtParaMiktari
            // 
            this.txtParaMiktari.Location = new System.Drawing.Point(193, 117);
            this.txtParaMiktari.Name = "txtParaMiktari";
            this.txtParaMiktari.Size = new System.Drawing.Size(251, 34);
            this.txtParaMiktari.TabIndex = 4;
            // 
            // cmbDaireNo
            // 
            this.cmbDaireNo.FormattingEnabled = true;
            this.cmbDaireNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbDaireNo.Location = new System.Drawing.Point(193, 43);
            this.cmbDaireNo.Name = "cmbDaireNo";
            this.cmbDaireNo.Size = new System.Drawing.Size(251, 35);
            this.cmbDaireNo.TabIndex = 3;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(463, 46);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(70, 27);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih:";
            // 
            // lblParaMiktarı
            // 
            this.lblParaMiktarı.AutoSize = true;
            this.lblParaMiktarı.Location = new System.Drawing.Point(25, 117);
            this.lblParaMiktarı.Name = "lblParaMiktarı";
            this.lblParaMiktarı.Size = new System.Drawing.Size(142, 27);
            this.lblParaMiktarı.TabIndex = 1;
            this.lblParaMiktarı.Text = "Para Miktarı:";
            // 
            // lblDaireNo
            // 
            this.lblDaireNo.AutoSize = true;
            this.lblDaireNo.Location = new System.Drawing.Point(59, 46);
            this.lblDaireNo.Name = "lblDaireNo";
            this.lblDaireNo.Size = new System.Drawing.Size(108, 27);
            this.lblDaireNo.TabIndex = 0;
            this.lblDaireNo.Text = "Daire No:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(44, 311);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 260);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(368, 311);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(223, 260);
            this.listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(691, 311);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(223, 260);
            this.listBox3.TabIndex = 3;
            // 
            // BinaGelirleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(944, 616);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gelirBox);
            this.Name = "BinaGelirleri";
            this.Text = "BinaGelirleri";
            this.Load += new System.EventHandler(this.BinaGelirleri_Load);
            this.gelirBox.ResumeLayout(false);
            this.gelirBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gelirBox;
        private System.Windows.Forms.Button btnGelirEkle;
        private System.Windows.Forms.DateTimePicker dateTarihPicker;
        private System.Windows.Forms.TextBox txtParaMiktari;
        private System.Windows.Forms.ComboBox cmbDaireNo;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblParaMiktarı;
        private System.Windows.Forms.Label lblDaireNo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}