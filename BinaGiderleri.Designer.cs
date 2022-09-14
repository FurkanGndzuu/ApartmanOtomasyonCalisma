namespace ApartmanOtomasyonCalisma
{
    partial class BinaGiderleri
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
            this.btnGiderEkle = new System.Windows.Forms.Button();
            this.dateTarihPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiderMiktari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkTemizlik = new System.Windows.Forms.CheckBox();
            this.checkAsansor = new System.Windows.Forms.CheckBox();
            this.checkSu = new System.Windows.Forms.CheckBox();
            this.checkElektrik = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGiderEkle);
            this.groupBox1.Controls.Add(this.dateTarihPicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGiderMiktari);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkTemizlik);
            this.groupBox1.Controls.Add(this.checkAsansor);
            this.groupBox1.Controls.Add(this.checkSu);
            this.groupBox1.Controls.Add(this.checkElektrik);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(61, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gider Ekle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnGiderEkle
            // 
            this.btnGiderEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGiderEkle.Location = new System.Drawing.Point(539, 187);
            this.btnGiderEkle.Name = "btnGiderEkle";
            this.btnGiderEkle.Size = new System.Drawing.Size(253, 62);
            this.btnGiderEkle.TabIndex = 8;
            this.btnGiderEkle.Text = "Gider Ekle";
            this.btnGiderEkle.UseVisualStyleBackColor = false;
            this.btnGiderEkle.Click += new System.EventHandler(this.btnGiderEkle_Click);
            // 
            // dateTarihPicker
            // 
            this.dateTarihPicker.Location = new System.Drawing.Point(539, 121);
            this.dateTarihPicker.Name = "dateTarihPicker";
            this.dateTarihPicker.Size = new System.Drawing.Size(253, 34);
            this.dateTarihPicker.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tarih:";
            // 
            // txtGiderMiktari
            // 
            this.txtGiderMiktari.Location = new System.Drawing.Point(539, 50);
            this.txtGiderMiktari.Name = "txtGiderMiktari";
            this.txtGiderMiktari.Size = new System.Drawing.Size(253, 34);
            this.txtGiderMiktari.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gider Miktarı:";
            // 
            // checkTemizlik
            // 
            this.checkTemizlik.AutoSize = true;
            this.checkTemizlik.Location = new System.Drawing.Point(65, 218);
            this.checkTemizlik.Name = "checkTemizlik";
            this.checkTemizlik.Size = new System.Drawing.Size(119, 31);
            this.checkTemizlik.TabIndex = 3;
            this.checkTemizlik.Text = "Temizlik";
            this.checkTemizlik.UseVisualStyleBackColor = true;
            // 
            // checkAsansor
            // 
            this.checkAsansor.AutoSize = true;
            this.checkAsansor.Location = new System.Drawing.Point(65, 162);
            this.checkAsansor.Name = "checkAsansor";
            this.checkAsansor.Size = new System.Drawing.Size(115, 31);
            this.checkAsansor.TabIndex = 2;
            this.checkAsansor.Text = "Asansör";
            this.checkAsansor.UseVisualStyleBackColor = true;
            // 
            // checkSu
            // 
            this.checkSu.AutoSize = true;
            this.checkSu.Location = new System.Drawing.Point(65, 105);
            this.checkSu.Name = "checkSu";
            this.checkSu.Size = new System.Drawing.Size(59, 31);
            this.checkSu.TabIndex = 1;
            this.checkSu.Text = "Su";
            this.checkSu.UseVisualStyleBackColor = true;
            // 
            // checkElektrik
            // 
            this.checkElektrik.AutoSize = true;
            this.checkElektrik.Location = new System.Drawing.Point(65, 56);
            this.checkElektrik.Name = "checkElektrik";
            this.checkElektrik.Size = new System.Drawing.Size(109, 31);
            this.checkElektrik.TabIndex = 0;
            this.checkElektrik.Text = "Elektrik";
            this.checkElektrik.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(61, 309);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 276);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(400, 309);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(237, 276);
            this.listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(730, 309);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(237, 276);
            this.listBox3.TabIndex = 3;
            // 
            // BinaGiderleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1039, 597);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BinaGiderleri";
            this.Text = "BinaGiderleri";
            this.Load += new System.EventHandler(this.BinaGiderleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGiderEkle;
        private System.Windows.Forms.DateTimePicker dateTarihPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiderMiktari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkTemizlik;
        private System.Windows.Forms.CheckBox checkAsansor;
        private System.Windows.Forms.CheckBox checkSu;
        private System.Windows.Forms.CheckBox checkElektrik;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}