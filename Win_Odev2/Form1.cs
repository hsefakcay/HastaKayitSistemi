namespace Win_Odev2
{
    public partial class Form1 : Form
    {
        private Panel panel;
        private TabControl tabControl;

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);

            listBoxHastalar.Name = "Hastalar";
            listBoxHastalar.SelectionMode = SelectionMode.MultiSimple;

        }

        List<Hasta> hastaListesi = new List<Hasta>();
        List<Hastane> hastaneListesi = new List<Hastane>();



        private void Form1_Load(object sender, EventArgs e)
        {
            string[] meslekler = { "Doktor", "Hem�ire", "M�hendis", "��renci", "Memur", "Di�er" };
            
            // Form y�klenirken meslekleri ComboBox'a ekle
            comboBoxMeslek.Items.AddRange(meslekler);


            tabPageHastaneTan�mlama(sender,e);
        }

        private void hastahane_tan�mlama_Click(object sender, EventArgs e)
        {
            page_Acma(sender, e);
        }
        private void hasta_tan�mlama_Click(object sender, EventArgs e)
        {
            page_Acma(sender, e);
        }

        private void doktor_tan�mlama_Click(object sender, EventArgs e)
        {
            page_Acma(sender, e);
        }

        private void randevu_olusturma_Click(object sender, EventArgs e)
        {
            page_Acma(sender, e);
        }

        private void teshis_kayit_Click(object sender, EventArgs e)
        {
            page_Acma(sender, e);
        }

        private void test_tahlil_Click(object sender, EventArgs e)
        {
            page_Acma(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyalar�|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = new Bitmap(openFileDialog.FileName);
            }
            
        }


        void page_Acma(object sender, EventArgs e)
        {
            Button tiklananButton = sender as Button;

            if (tiklananButton != null)
            {
                switch (tiklananButton.Text)
                {
                    case "Hastahane Tan�mlama":
                        // button1 t�kland���nda ilgili sekmeyi g�stermek i�in kodu ekleyin
                        tabControl1.SelectedTab = tabControl1.TabPages[0];
                        break;
                    case "Hasta Tan�mlama":
                        tabControl1.SelectedTab = tabControl1.TabPages[1];
                        break;
                    case "Doktor Tan�mlama":
                        tabControl1.SelectedTab = tabControl1.TabPages[2];
                        break;
                    case "Randevu Olu�turma":
                        tabControl1.SelectedTab = tabControl1.TabPages[3];
                        break;
                    case "Te�his Kay�t":
                        tabControl1.SelectedTab = tabControl1.TabPages[4];
                        break;
                    case "Test Tahlil":
                        tabControl1.SelectedTab = tabControl1.TabPages[5];
                        break;
                }
            }
        }
        private void tabPageHastaneTan�mlama(object sender, EventArgs e)
        {
            // Checked list box'a poliklinikleri ekle
            string[] iller = { "�stanbul", "Ankara", "�zmir" };
            string[] poliklinikler = { "Dahiliye", "Genel Cerrahi", "G�z", "Ortopedi", "�roloji", "Kardiyoloji", "Acil Servis" };

            checkedListBoxPolik.Items.AddRange(poliklinikler);
            // Form y�klenirken illeri ComboBox'a ekle
            comboBox�l.Items.AddRange(iller);

            // �l�eleri ilgili ilin se�imine g�re g�ncelleyin
            comboBox�l.SelectedIndexChanged += (s, evt) =>
            {
                comboBox�l�e.Items.Clear();

                if (comboBox�l.SelectedIndex == 0) // �stanbul
                {
                    comboBox�l�e.Items.Add("Be�ikta�");
                    comboBox�l�e.Items.Add("Kad�k�y");
                    comboBox�l�e.Items.Add("�i�li");
                    
                }
                else if (comboBox�l.SelectedIndex == 1) // Ankara
                {
                    comboBox�l�e.Items.Add("�ankaya");
                    comboBox�l�e.Items.Add("Ke�i�ren");
                    comboBox�l�e.Items.Add("Yenimahalle");
                   
                }
                else if (comboBox�l.SelectedIndex == 2) // �zmir
                {
                    comboBox�l�e.Items.Add("Kar��yaka");
                    comboBox�l�e.Items.Add("Konak");
                    comboBox�l�e.Items.Add("Buca");
                    comboBox�l�e.Items.Add("Bornova");
                }
            };
        }


        private void kaydetButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageHastane)
            {
                HastaneKaydet();
            }
            else if (tabControl1.SelectedTab == tabPageHasta)
            {
                HastaKaydet();
            }
            
        }


        private void HastaneKaydet()
        {
            List<string> seciliPoliklinikler = new List<string>();
            foreach (var item in checkedListBoxPolik.CheckedItems)
            {
                seciliPoliklinikler.Add(item.ToString());
            }

            Hastane yeniHastane = new Hastane();
            yeniHastane.HastaneAdi = textBoxHastaneAd.Text;
            yeniHastane.Hastane�li = comboBox�l.SelectedItem.ToString();
            yeniHastane.HastaneIlce = comboBox�l�e.SelectedItem.ToString();
            yeniHastane.HastaneTelefon = textBoxHastaneTel.Text;
            yeniHastane.Poliklinikler = seciliPoliklinikler;

            listBoxHastaneler.Items.Add(yeniHastane);

            hastaneListesi.Add(yeniHastane);
        }


        private void HastaKaydet()
        {
            /*
            // Form �zerindeki bilgileri kontrol et
            if (string.IsNullOrWhiteSpace(textAd.Text) || string.IsNullOrWhiteSpace(textSoyad.Text) ||
                string.IsNullOrWhiteSpace(textAdres.Text) || string.IsNullOrWhiteSpace(textEmail.Text) ||
                string.IsNullOrWhiteSpace(textTelefon.Text))
            {
                MessageBox.Show("L�tfen t�m alanlar� doldurun.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxMeslek.SelectedItem == null )
            {
                MessageBox.Show("L�tfen meslek se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((radioButtonErkek.Checked == false && radioButtonKad�n.Checked == false))
            {
                MessageBox.Show("L�tfen cinsiyet se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pictureBoxFoto.Image == null)
            {
                MessageBox.Show("L�tfen foto�raf ekleyiniz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            */

            Hasta yeniHasta = new Hasta();
            yeniHasta.Ad = textAd.Text;
            yeniHasta.Soyad = textSoyad.Text;
            yeniHasta.TamAd = textAd.Text + " " + textSoyad.Text;
            yeniHasta.Adres = textAdres.Text;
            yeniHasta.Email = textEmail.Text;
            yeniHasta.Telefon = textTelefon.Text;
            yeniHasta.Meslek = comboBoxMeslek.SelectedItem.ToString();
            yeniHasta.Cinsiyet = radioButtonErkek.Checked ? "Erkek" : "Kad�n";
            yeniHasta.Foto = pictureBoxFoto.Image;

            //hasta listeye eklenir nesne olarak
            hastaListesi.Add(yeniHasta);
            // Hasta bilgilerini ListViewItem olarak olu�tur
            listBoxHastalar.Items.Add(yeniHasta);

            HastaKay�tFormTemizle();
        }

        private void HastaKay�tFormTemizle()
        {
            // TextBox'lar� ve di�er kontrol de�erlerini temizle
            textAd.Clear();
            textSoyad.Clear();
            textAdres.Clear();
            textTelefon.Clear();
            textTamAd.Clear();
            textEmail.Clear();
            textTelefon.Clear();
            comboBoxMeslek.SelectedIndex = -1;
            radioButtonErkek.Checked = false;
            radioButtonKad�n.Checked = false;
            pictureBoxFoto.Image = null;
        }

        private void textAd_TextChanged(object sender, EventArgs e)
        {
            UpdateTamAd();
        }

        private void textSoyad_TextChanged(object sender, EventArgs e)
        {
            UpdateTamAd();
        }

        private void UpdateTamAd()
        {
            string ad = textAd.Text;
            string soyad = textSoyad.Text;

            // Ad ve Soyad doluysa Tam Ad'� g�ncelle
            if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(soyad))
            {
                textTamAd.Text = $"{ad} {soyad}";
            }
            else
            {
                textTamAd.Text = string.Empty;
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (listBoxHastalar.SelectedIndex != -1) //se�ili ��e var m� 
            {
                //secili hasta al�nd�
                Hasta seciliHasta = (Hasta)listBoxHastalar.SelectedItem;
                // Se�ili hastay� ListBox'tan kald�r�ld�
                listBoxHastalar.Items.RemoveAt(listBoxHastalar.SelectedIndex);
                // secili hastay� hastaListe listeden kald�r�ld�
                hastaListesi.Remove(seciliHasta);
                
            }
            else
            {
                MessageBox.Show("L�tfen silinecek bir ��e se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSec_Click(object sender, EventArgs e)
        {
            // ListBox'ta se�ili bir ��e var m� kontrol et
                if (listBoxHastalar.SelectedIndex != -1)
            {
                // Se�ili ��eyi al
                Hasta seciliHasta = (Hasta)listBoxHastalar.SelectedItem;

                // �rne�in, se�ili hastan�n ad�n� bir MessageBox ile g�ster
                MessageBox.Show($"Se�ili Hasta: {seciliHasta.Ad} {seciliHasta.Soyad}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("L�tfen bir ��e se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            // ListBox'ta se�ili bir ��e var m� kontrol et
            if (listBoxHastalar.SelectedIndex != -1)
            {
                Hasta seciliHasta = (Hasta)listBoxHastalar.SelectedItem;

                // Se�ili hasta bilgilerini g�ster
                textAd.Text=seciliHasta.Ad;
                textSoyad.Text=seciliHasta.Soyad;
                textTamAd.Text = seciliHasta.TamAd;
                textAdres.Text=seciliHasta.Adres;
                textEmail.Text=seciliHasta.Email;
                textTelefon.Text=seciliHasta.Telefon;
                comboBoxMeslek.Text=seciliHasta.Meslek;
                pictureBoxFoto.Image = seciliHasta.Foto;
                
                // Se�ili hasta bilgilerini g�ncelle
                seciliHasta.Ad = textAd.Text;
                seciliHasta.Soyad = textSoyad.Text;
                seciliHasta.TamAd = textAd.Text + " " + textSoyad.Text;
                seciliHasta.Adres = textAdres.Text;
                seciliHasta.Email = textEmail.Text;
                seciliHasta.Telefon = textTelefon.Text;
                seciliHasta.Meslek = comboBoxMeslek.SelectedItem.ToString();
                seciliHasta.Cinsiyet = radioButtonErkek.Checked ? "Erkek" : "Kad�n";
                seciliHasta.Foto = pictureBoxFoto.Image;

                // ListBox'taki g�r�nt�y� g�ncelle
                listBoxHastalar.Items[listBoxHastalar.SelectedIndex] = seciliHasta;

                // hastaListesi i�indeki ��eyi g�ncelle (FindIndex metodu kullan�yoruz)
                int index = hastaListesi.FindIndex(hasta => hasta == seciliHasta);
                if (index != -1)
                {
                    hastaListesi[index] = seciliHasta;
                }
            }
            else
            {
                MessageBox.Show("L�tfen g�ncellenecek bir ��e se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
