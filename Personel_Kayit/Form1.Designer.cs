namespace Personel_Kayit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label7 = new Label();
            MskMaas = new MaskedTextBox();
            radioButton2 = new RadioButton();
            label6 = new Label();
            radioButton1 = new RadioButton();
            CmbSehir = new ComboBox();
            TxtMeslek = new TextBox();
            TxtId = new TextBox();
            label5 = new Label();
            label1 = new Label();
            TxtAd = new TextBox();
            label4 = new Label();
            label2 = new Label();
            TxtSoyad = new TextBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            BtnTemizle = new Button();
            BtnGuncelle = new Button();
            BtnSil = new Button();
            BtnKaydet = new Button();
            BtnListele = new Button();
            Kayıtlar = new GroupBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            BtnIstatistik = new Button();
            BtnGrafikler = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            Kayıtlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(MskMaas);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(CmbSehir);
            groupBox1.Controls.Add(TxtMeslek);
            groupBox1.Controls.Add(TxtId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtAd);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 324);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Kayıt";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 213);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 14;
            label7.Text = "Maaş :";
            // 
            // MskMaas
            // 
            MskMaas.Location = new Point(72, 212);
            MskMaas.Mask = "0000";
            MskMaas.Name = "MskMaas";
            MskMaas.Size = new Size(125, 27);
            MskMaas.TabIndex = 5;
            MskMaas.ValidatingType = typeof(int);
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(135, 245);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Bekar";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 289);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 10;
            label6.Text = "Meslek :";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(76, 245);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Evli";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // CmbSehir
            // 
            CmbSehir.FormattingEnabled = true;
            CmbSehir.Location = new Point(72, 162);
            CmbSehir.Name = "CmbSehir";
            CmbSehir.Size = new Size(125, 28);
            CmbSehir.TabIndex = 4;
            // 
            // TxtMeslek
            // 
            TxtMeslek.Location = new Point(72, 288);
            TxtMeslek.Name = "TxtMeslek";
            TxtMeslek.Size = new Size(125, 27);
            TxtMeslek.TabIndex = 8;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(72, 33);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(125, 27);
            TxtId.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 245);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 8;
            label5.Text = "Durum :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 34);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "Id :";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(72, 75);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(125, 27);
            TxtAd.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 163);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Şehir :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 76);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 2;
            label2.Text = "Ad :";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(72, 117);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(125, 27);
            TxtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 122);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "Soyad : ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnGrafikler);
            groupBox3.Controls.Add(BtnIstatistik);
            groupBox3.Controls.Add(BtnTemizle);
            groupBox3.Controls.Add(BtnGuncelle);
            groupBox3.Controls.Add(BtnSil);
            groupBox3.Controls.Add(BtnKaydet);
            groupBox3.Controls.Add(BtnListele);
            groupBox3.Location = new Point(372, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(207, 324);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "İşlemler";
            // 
            // BtnTemizle
            // 
            BtnTemizle.Location = new Point(45, 200);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(125, 31);
            BtnTemizle.TabIndex = 13;
            BtnTemizle.Text = "Temizle";
            BtnTemizle.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(45, 160);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(125, 31);
            BtnGuncelle.TabIndex = 12;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnSil
            // 
            BtnSil.Location = new Point(45, 117);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(125, 31);
            BtnSil.TabIndex = 11;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Location = new Point(45, 75);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(125, 31);
            BtnKaydet.TabIndex = 10;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // BtnListele
            // 
            BtnListele.Location = new Point(45, 33);
            BtnListele.Name = "BtnListele";
            BtnListele.Size = new Size(125, 31);
            BtnListele.TabIndex = 9;
            BtnListele.Text = "Listele";
            BtnListele.UseVisualStyleBackColor = true;
            // 
            // Kayıtlar
            // 
            Kayıtlar.Controls.Add(dataGridView1);
            Kayıtlar.Location = new Point(2, 332);
            Kayıtlar.Name = "Kayıtlar";
            Kayıtlar.Size = new Size(862, 198);
            Kayıtlar.TabIndex = 12;
            Kayıtlar.TabStop = false;
            Kayıtlar.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(856, 172);
            dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(580, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // BtnIstatistik
            // 
            BtnIstatistik.Location = new Point(45, 240);
            BtnIstatistik.Name = "BtnIstatistik";
            BtnIstatistik.Size = new Size(125, 31);
            BtnIstatistik.TabIndex = 14;
            BtnIstatistik.Text = "İstatistik";
            BtnIstatistik.UseVisualStyleBackColor = true;
            // 
            // BtnGrafikler
            // 
            BtnGrafikler.Location = new Point(45, 284);
            BtnGrafikler.Name = "BtnGrafikler";
            BtnGrafikler.Size = new Size(125, 31);
            BtnGrafikler.TabIndex = 15;
            BtnGrafikler.Text = "Grafikler";
            BtnGrafikler.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(872, 533);
            Controls.Add(pictureBox1);
            Controls.Add(Kayıtlar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            Kayıtlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox CmbSehir;
        private TextBox TxtId;
        private Label label1;
        private TextBox TxtAd;
        private Label label2;
        private TextBox TxtSoyad;
        private Label label3;
        private Label label4;
        private TextBox TxtMeslek;
        private Label label5;
        private RadioButton radioButton2;
        private Label label6;
        private RadioButton radioButton1;
        private GroupBox groupBox3;
        private Button BtnTemizle;
        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnKaydet;
        private Button BtnListele;
        private GroupBox Kayıtlar;
        private DataGridView dataGridView1;
        private Label label7;
        private MaskedTextBox MskMaas;
        private PictureBox pictureBox1;
        private Button BtnGrafikler;
        private Button BtnIstatistik;
    }
}
