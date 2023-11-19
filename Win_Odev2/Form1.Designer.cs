namespace Win_Odev2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSec = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHastane = new System.Windows.Forms.TabPage();
            this.listBoxHastaneler = new System.Windows.Forms.ListBox();
            this.comboBoxİl = new System.Windows.Forms.ComboBox();
            this.comboBoxİlçe = new System.Windows.Forms.ComboBox();
            this.checkedListBoxPolik = new System.Windows.Forms.CheckedListBox();
            this.textBoxHastaneTel = new System.Windows.Forms.TextBox();
            this.textBoxHastaneAd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageHasta = new System.Windows.Forms.TabPage();
            this.listBoxHastalar = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonKadın = new System.Windows.Forms.RadioButton();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxMeslek = new System.Windows.Forms.ComboBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.textTamAd = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageDoktor = new System.Windows.Forms.TabPage();
            this.tabPageRandevu = new System.Windows.Forms.TabPage();
            this.tabPageTeshis = new System.Windows.Forms.TabPage();
            this.tabPageTest = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageHastane.SuspendLayout();
            this.tabPageHasta.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MistyRose;
            this.button6.Location = new System.Drawing.Point(11, 321);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "Test Tahlil";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.test_tahlil_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MistyRose;
            this.button5.Location = new System.Drawing.Point(11, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "Teşhis Kayıt";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.teshis_kayit_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MistyRose;
            this.button4.Location = new System.Drawing.Point(11, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Randevu Oluşturma";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.randevu_olusturma_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Location = new System.Drawing.Point(11, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Doktor Tanımlama";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.doktor_tanımlama_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Location = new System.Drawing.Point(11, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hasta Tanımlama";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.hasta_tanımlama_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(11, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hastahane Tanımlama";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.hastahane_tanımlama_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKaydet.Location = new System.Drawing.Point(16, 11);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(80, 35);
            this.buttonKaydet.TabIndex = 1;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSil.Location = new System.Drawing.Point(353, 12);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(80, 35);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGuncelle.Location = new System.Drawing.Point(129, 12);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(80, 35);
            this.buttonGuncelle.TabIndex = 3;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSec
            // 
            this.buttonSec.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSec.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSec.Location = new System.Drawing.Point(242, 12);
            this.buttonSec.Name = "buttonSec";
            this.buttonSec.Size = new System.Drawing.Size(80, 35);
            this.buttonSec.TabIndex = 4;
            this.buttonSec.Text = "Seç";
            this.buttonSec.UseVisualStyleBackColor = false;
            this.buttonSec.Click += new System.EventHandler(this.buttonSec_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.buttonKaydet);
            this.groupBox2.Controls.Add(this.buttonSil);
            this.groupBox2.Controls.Add(this.buttonSec);
            this.groupBox2.Controls.Add(this.buttonGuncelle);
            this.groupBox2.Location = new System.Drawing.Point(189, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 58);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(189, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 473);
            this.panel1.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(432, 458);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 15);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHastane);
            this.tabControl1.Controls.Add(this.tabPageHasta);
            this.tabControl1.Controls.Add(this.tabPageDoktor);
            this.tabControl1.Controls.Add(this.tabPageRandevu);
            this.tabControl1.Controls.Add(this.tabPageTeshis);
            this.tabControl1.Controls.Add(this.tabPageTest);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 462);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageHastane
            // 
            this.tabPageHastane.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageHastane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageHastane.Controls.Add(this.listBoxHastaneler);
            this.tabPageHastane.Controls.Add(this.comboBoxİl);
            this.tabPageHastane.Controls.Add(this.comboBoxİlçe);
            this.tabPageHastane.Controls.Add(this.checkedListBoxPolik);
            this.tabPageHastane.Controls.Add(this.textBoxHastaneTel);
            this.tabPageHastane.Controls.Add(this.textBoxHastaneAd);
            this.tabPageHastane.Controls.Add(this.label15);
            this.tabPageHastane.Controls.Add(this.label14);
            this.tabPageHastane.Controls.Add(this.label13);
            this.tabPageHastane.Controls.Add(this.label12);
            this.tabPageHastane.Controls.Add(this.label11);
            this.tabPageHastane.Location = new System.Drawing.Point(4, 24);
            this.tabPageHastane.Name = "tabPageHastane";
            this.tabPageHastane.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHastane.Size = new System.Drawing.Size(624, 434);
            this.tabPageHastane.TabIndex = 0;
            this.tabPageHastane.Text = "Hastahane Tanımlama";
            // 
            // listBoxHastaneler
            // 
            this.listBoxHastaneler.FormattingEnabled = true;
            this.listBoxHastaneler.ItemHeight = 15;
            this.listBoxHastaneler.Location = new System.Drawing.Point(11, 253);
            this.listBoxHastaneler.Name = "listBoxHastaneler";
            this.listBoxHastaneler.Size = new System.Drawing.Size(603, 154);
            this.listBoxHastaneler.TabIndex = 10;
            // 
            // comboBoxİl
            // 
            this.comboBoxİl.FormattingEnabled = true;
            this.comboBoxİl.Location = new System.Drawing.Point(155, 83);
            this.comboBoxİl.Name = "comboBoxİl";
            this.comboBoxİl.Size = new System.Drawing.Size(121, 23);
            this.comboBoxİl.TabIndex = 9;
            // 
            // comboBoxİlçe
            // 
            this.comboBoxİlçe.FormattingEnabled = true;
            this.comboBoxİlçe.Location = new System.Drawing.Point(155, 126);
            this.comboBoxİlçe.Name = "comboBoxİlçe";
            this.comboBoxİlçe.Size = new System.Drawing.Size(121, 23);
            this.comboBoxİlçe.TabIndex = 8;
            // 
            // checkedListBoxPolik
            // 
            this.checkedListBoxPolik.FormattingEnabled = true;
            this.checkedListBoxPolik.Location = new System.Drawing.Point(344, 61);
            this.checkedListBoxPolik.Name = "checkedListBoxPolik";
            this.checkedListBoxPolik.Size = new System.Drawing.Size(178, 94);
            this.checkedListBoxPolik.TabIndex = 7;
            // 
            // textBoxHastaneTel
            // 
            this.textBoxHastaneTel.Location = new System.Drawing.Point(155, 175);
            this.textBoxHastaneTel.Name = "textBoxHastaneTel";
            this.textBoxHastaneTel.Size = new System.Drawing.Size(121, 23);
            this.textBoxHastaneTel.TabIndex = 6;
            // 
            // textBoxHastaneAd
            // 
            this.textBoxHastaneAd.Location = new System.Drawing.Point(155, 38);
            this.textBoxHastaneAd.Name = "textBoxHastaneAd";
            this.textBoxHastaneAd.Size = new System.Drawing.Size(121, 23);
            this.textBoxHastaneAd.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(45, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "Hastane Telefonu :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(344, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Hastanede Bulunan Poliklinikler :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(45, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Hastane İlçesi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(45, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Hastane İli :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(45, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hastane Adı :";
            // 
            // tabPageHasta
            // 
            this.tabPageHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageHasta.Controls.Add(this.listBoxHastalar);
            this.tabPageHasta.Controls.Add(this.groupBox3);
            this.tabPageHasta.Controls.Add(this.comboBoxMeslek);
            this.tabPageHasta.Controls.Add(this.pictureBoxFoto);
            this.tabPageHasta.Controls.Add(this.textEmail);
            this.tabPageHasta.Controls.Add(this.textTelefon);
            this.tabPageHasta.Controls.Add(this.textAdres);
            this.tabPageHasta.Controls.Add(this.textTamAd);
            this.tabPageHasta.Controls.Add(this.textSoyad);
            this.tabPageHasta.Controls.Add(this.textAd);
            this.tabPageHasta.Controls.Add(this.label9);
            this.tabPageHasta.Controls.Add(this.label8);
            this.tabPageHasta.Controls.Add(this.label7);
            this.tabPageHasta.Controls.Add(this.label6);
            this.tabPageHasta.Controls.Add(this.label5);
            this.tabPageHasta.Controls.Add(this.label4);
            this.tabPageHasta.Controls.Add(this.label3);
            this.tabPageHasta.Controls.Add(this.label2);
            this.tabPageHasta.Controls.Add(this.label1);
            this.tabPageHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageHasta.Location = new System.Drawing.Point(4, 24);
            this.tabPageHasta.Name = "tabPageHasta";
            this.tabPageHasta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHasta.Size = new System.Drawing.Size(624, 434);
            this.tabPageHasta.TabIndex = 1;
            this.tabPageHasta.Text = "Hasta Tanımlama";
            this.tabPageHasta.UseVisualStyleBackColor = true;
            // 
            // listBoxHastalar
            // 
            this.listBoxHastalar.FormattingEnabled = true;
            this.listBoxHastalar.ItemHeight = 15;
            this.listBoxHastalar.Location = new System.Drawing.Point(3, 259);
            this.listBoxHastalar.Name = "listBoxHastalar";
            this.listBoxHastalar.Size = new System.Drawing.Size(618, 169);
            this.listBoxHastalar.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox3.Controls.Add(this.radioButtonKadın);
            this.groupBox3.Controls.Add(this.radioButtonErkek);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(335, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 52);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // radioButtonKadın
            // 
            this.radioButtonKadın.AutoSize = true;
            this.radioButtonKadın.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonKadın.Location = new System.Drawing.Point(85, 26);
            this.radioButtonKadın.Name = "radioButtonKadın";
            this.radioButtonKadın.Size = new System.Drawing.Size(56, 19);
            this.radioButtonKadın.TabIndex = 22;
            this.radioButtonKadın.TabStop = true;
            this.radioButtonKadın.Text = "Kadın";
            this.radioButtonKadın.UseVisualStyleBackColor = true;
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonErkek.Location = new System.Drawing.Point(26, 26);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(57, 19);
            this.radioButtonErkek.TabIndex = 21;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(11, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cinsiyet";
            // 
            // comboBoxMeslek
            // 
            this.comboBoxMeslek.FormattingEnabled = true;
            this.comboBoxMeslek.Location = new System.Drawing.Point(335, 141);
            this.comboBoxMeslek.Name = "comboBoxMeslek";
            this.comboBoxMeslek.Size = new System.Drawing.Size(150, 23);
            this.comboBoxMeslek.TabIndex = 18;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackgroundImage = global::Win_Odev2.Properties.Resources.add_user;
            this.pictureBoxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFoto.Location = new System.Drawing.Point(508, 25);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(100, 111);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 16;
            this.pictureBoxFoto.TabStop = false;
            this.pictureBoxFoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(335, 60);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(150, 23);
            this.textEmail.TabIndex = 15;
            // 
            // textTelefon
            // 
            this.textTelefon.Location = new System.Drawing.Point(335, 101);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(150, 23);
            this.textTelefon.TabIndex = 14;
            // 
            // textAdres
            // 
            this.textAdres.Location = new System.Drawing.Point(110, 136);
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(150, 23);
            this.textAdres.TabIndex = 12;
            // 
            // textTamAd
            // 
            this.textTamAd.Location = new System.Drawing.Point(110, 101);
            this.textTamAd.Name = "textTamAd";
            this.textTamAd.Size = new System.Drawing.Size(150, 23);
            this.textTamAd.TabIndex = 11;
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(110, 60);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(150, 23);
            this.textSoyad.TabIndex = 10;
            this.textSoyad.TextChanged += new System.EventHandler(this.textSoyad_TextChanged);
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(110, 25);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(150, 23);
            this.textAd.TabIndex = 9;
            this.textAd.TextChanged += new System.EventHandler(this.textAd_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(26, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kayıtları Yapılan Hastalar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(438, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fotoğrafı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(277, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Meslek :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(277, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(277, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta TamAdı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Adı :";
            // 
            // tabPageDoktor
            // 
            this.tabPageDoktor.Location = new System.Drawing.Point(4, 24);
            this.tabPageDoktor.Name = "tabPageDoktor";
            this.tabPageDoktor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoktor.Size = new System.Drawing.Size(624, 434);
            this.tabPageDoktor.TabIndex = 2;
            this.tabPageDoktor.Text = "Doktor Tanımlama";
            this.tabPageDoktor.UseVisualStyleBackColor = true;
            // 
            // tabPageRandevu
            // 
            this.tabPageRandevu.Location = new System.Drawing.Point(4, 24);
            this.tabPageRandevu.Name = "tabPageRandevu";
            this.tabPageRandevu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRandevu.Size = new System.Drawing.Size(624, 434);
            this.tabPageRandevu.TabIndex = 3;
            this.tabPageRandevu.Text = "Randevu Oluşturma";
            this.tabPageRandevu.UseVisualStyleBackColor = true;
            // 
            // tabPageTeshis
            // 
            this.tabPageTeshis.Location = new System.Drawing.Point(4, 24);
            this.tabPageTeshis.Name = "tabPageTeshis";
            this.tabPageTeshis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeshis.Size = new System.Drawing.Size(624, 434);
            this.tabPageTeshis.TabIndex = 4;
            this.tabPageTeshis.Text = "Teşhis Kayıt";
            this.tabPageTeshis.UseVisualStyleBackColor = true;
            // 
            // tabPageTest
            // 
            this.tabPageTest.Location = new System.Drawing.Point(4, 24);
            this.tabPageTest.Name = "tabPageTest";
            this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTest.Size = new System.Drawing.Size(624, 434);
            this.tabPageTest.TabIndex = 5;
            this.tabPageTest.Text = "Test Tahlil";
            this.tabPageTest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hasta Kayıt Sistemi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageHastane.ResumeLayout(false);
            this.tabPageHastane.PerformLayout();
            this.tabPageHasta.ResumeLayout(false);
            this.tabPageHasta.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button buttonKaydet;
        private Button buttonSil;
        private Button buttonGuncelle;
        private Button buttonSec;
        private GroupBox groupBox2;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageHastane;
        private TabPage tabPageHasta;
        private TabPage tabPageDoktor;
        private TabPage tabPageRandevu;
        private TabPage tabPageTeshis;
        private TabPage tabPageTest;
        private TextBox textAd;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBoxFoto;
        private TextBox textEmail;
        private TextBox textTelefon;
        private TextBox textAdres;
        private TextBox textTamAd;
        private TextBox textSoyad;
        private LinkLabel linkLabel1;
        private RadioButton radioButtonKadın;
        private GroupBox groupBox3;
        private RadioButton radioButtonErkek;
        private Label label10;
        private ComboBox comboBoxMeslek;
        private ListView listViewHastaListesi;
        private ListBox listBoxHastalar;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private ComboBox comboBoxİl;
        private ComboBox comboBoxİlçe;
        private CheckedListBox checkedListBoxPolik;
        private TextBox textBoxHastaneTel;
        private TextBox textBoxHastaneAd;
        private ListBox listBoxHastaneler;
    }
}