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
            string[] meslekler = { "Doktor", "Hemþire", "Mühendis", "Öðrenci", "Memur", "Diðer" };
            
            // Form yüklenirken meslekleri ComboBox'a ekle
            comboBoxMeslek.Items.AddRange(meslekler);


            tabPageHastaneTanýmlama(sender,e);
        }

        private void hastahane_tanýmlama_Click(object sender, EventArgs e)
        {
            page_Acma(sender, e);
        }
        private void hasta_tanýmlama_Click(object sender, EventArgs e)
        {
            page_Acma(sender, e);
        }

        private void doktor_tanýmlama_Click(object sender, EventArgs e)
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
            openFileDialog.Filter = "Resim Dosyalarý|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
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
                    case "Hastahane Tanýmlama":
                        // button1 týklandýðýnda ilgili sekmeyi göstermek için kodu ekleyin
                        tabControl1.SelectedTab = tabControl1.TabPages[0];
                        break;
                    case "Hasta Tanýmlama":
                        tabControl1.SelectedTab = tabControl1.TabPages[1];
                        break;
                    case "Doktor Tanýmlama":
                        tabControl1.SelectedTab = tabControl1.TabPages[2];
                        break;
                    case "Randevu Oluþturma":
                        tabControl1.SelectedTab = tabControl1.TabPages[3];
                        break;
                    case "Teþhis Kayýt":
                        tabControl1.SelectedTab = tabControl1.TabPages[4];
                        break;
                    case "Test Tahlil":
                        tabControl1.SelectedTab = tabControl1.TabPages[5];
                        break;
                }
            }
        }
        private void tabPageHastaneTanýmlama(object sender, EventArgs e)
        {
            // Checked list box'a poliklinikleri ekle
            string[] iller = { "Ýstanbul", "Ankara", "Ýzmir" };
            string[] poliklinikler = { "Dahiliye", "Genel Cerrahi", "Göz", "Ortopedi", "Üroloji", "Kardiyoloji", "Acil Servis" };

            checkedListBoxPolik.Items.AddRange(poliklinikler);
            // Form yüklenirken illeri ComboBox'a ekle
            comboBoxÝl.Items.AddRange(iller);

            // Ýlçeleri ilgili ilin seçimine göre güncelleyin
            comboBoxÝl.SelectedIndexChanged += (s, evt) =>
            {
                comboBoxÝlçe.Items.Clear();

                if (comboBoxÝl.SelectedIndex == 0) // Ýstanbul
                {
                    comboBoxÝlçe.Items.Add("Beþiktaþ");
                    comboBoxÝlçe.Items.Add("Kadýköy");
                    comboBoxÝlçe.Items.Add("Þiþli");
                    
                }
                else if (comboBoxÝl.SelectedIndex == 1) // Ankara
                {
                    comboBoxÝlçe.Items.Add("Çankaya");
                    comboBoxÝlçe.Items.Add("Keçiören");
                    comboBoxÝlçe.Items.Add("Yenimahalle");
                   
                }
                else if (comboBoxÝl.SelectedIndex == 2) // Ýzmir
                {
                    comboBoxÝlçe.Items.Add("Karþýyaka");
                    comboBoxÝlçe.Items.Add("Konak");
                    comboBoxÝlçe.Items.Add("Buca");
                    comboBoxÝlçe.Items.Add("Bornova");
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
            yeniHastane.HastaneÝli = comboBoxÝl.SelectedItem.ToString();
            yeniHastane.HastaneIlce = comboBoxÝlçe.SelectedItem.ToString();
            yeniHastane.HastaneTelefon = textBoxHastaneTel.Text;
            yeniHastane.Poliklinikler = seciliPoliklinikler;

            listBoxHastaneler.Items.Add(yeniHastane);

            hastaneListesi.Add(yeniHastane);
        }


        private void HastaKaydet()
        {
            /*
            // Form üzerindeki bilgileri kontrol et
            if (string.IsNullOrWhiteSpace(textAd.Text) || string.IsNullOrWhiteSpace(textSoyad.Text) ||
                string.IsNullOrWhiteSpace(textAdres.Text) || string.IsNullOrWhiteSpace(textEmail.Text) ||
                string.IsNullOrWhiteSpace(textTelefon.Text))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxMeslek.SelectedItem == null )
            {
                MessageBox.Show("Lütfen meslek seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((radioButtonErkek.Checked == false && radioButtonKadýn.Checked == false))
            {
                MessageBox.Show("Lütfen cinsiyet seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pictureBoxFoto.Image == null)
            {
                MessageBox.Show("Lütfen fotoðraf ekleyiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            yeniHasta.Cinsiyet = radioButtonErkek.Checked ? "Erkek" : "Kadýn";
            yeniHasta.Foto = pictureBoxFoto.Image;

            //hasta listeye eklenir nesne olarak
            hastaListesi.Add(yeniHasta);
            // Hasta bilgilerini ListViewItem olarak oluþtur
            listBoxHastalar.Items.Add(yeniHasta);

            HastaKayýtFormTemizle();
        }

        private void HastaKayýtFormTemizle()
        {
            // TextBox'larý ve diðer kontrol deðerlerini temizle
            textAd.Clear();
            textSoyad.Clear();
            textAdres.Clear();
            textTelefon.Clear();
            textTamAd.Clear();
            textEmail.Clear();
            textTelefon.Clear();
            comboBoxMeslek.SelectedIndex = -1;
            radioButtonErkek.Checked = false;
            radioButtonKadýn.Checked = false;
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

            // Ad ve Soyad doluysa Tam Ad'ý güncelle
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
            if (listBoxHastalar.SelectedIndex != -1) //seçili öðe var mý 
            {
                //secili hasta alýndý
                Hasta seciliHasta = (Hasta)listBoxHastalar.SelectedItem;
                // Seçili hastayý ListBox'tan kaldýrýldý
                listBoxHastalar.Items.RemoveAt(listBoxHastalar.SelectedIndex);
                // secili hastayý hastaListe listeden kaldýrýldý
                hastaListesi.Remove(seciliHasta);
                
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir öðe seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSec_Click(object sender, EventArgs e)
        {
            // ListBox'ta seçili bir öðe var mý kontrol et
                if (listBoxHastalar.SelectedIndex != -1)
            {
                // Seçili öðeyi al
                Hasta seciliHasta = (Hasta)listBoxHastalar.SelectedItem;

                // Örneðin, seçili hastanýn adýný bir MessageBox ile göster
                MessageBox.Show($"Seçili Hasta: {seciliHasta.Ad} {seciliHasta.Soyad}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir öðe seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            // ListBox'ta seçili bir öðe var mý kontrol et
            if (listBoxHastalar.SelectedIndex != -1)
            {
                Hasta seciliHasta = (Hasta)listBoxHastalar.SelectedItem;

                // Seçili hasta bilgilerini göster
                textAd.Text=seciliHasta.Ad;
                textSoyad.Text=seciliHasta.Soyad;
                textTamAd.Text = seciliHasta.TamAd;
                textAdres.Text=seciliHasta.Adres;
                textEmail.Text=seciliHasta.Email;
                textTelefon.Text=seciliHasta.Telefon;
                comboBoxMeslek.Text=seciliHasta.Meslek;
                pictureBoxFoto.Image = seciliHasta.Foto;
                
                // Seçili hasta bilgilerini güncelle
                seciliHasta.Ad = textAd.Text;
                seciliHasta.Soyad = textSoyad.Text;
                seciliHasta.TamAd = textAd.Text + " " + textSoyad.Text;
                seciliHasta.Adres = textAdres.Text;
                seciliHasta.Email = textEmail.Text;
                seciliHasta.Telefon = textTelefon.Text;
                seciliHasta.Meslek = comboBoxMeslek.SelectedItem.ToString();
                seciliHasta.Cinsiyet = radioButtonErkek.Checked ? "Erkek" : "Kadýn";
                seciliHasta.Foto = pictureBoxFoto.Image;

                // ListBox'taki görüntüyü güncelle
                listBoxHastalar.Items[listBoxHastalar.SelectedIndex] = seciliHasta;

                // hastaListesi içindeki öðeyi güncelle (FindIndex metodu kullanýyoruz)
                int index = hastaListesi.FindIndex(hasta => hasta == seciliHasta);
                if (index != -1)
                {
                    hastaListesi[index] = seciliHasta;
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir öðe seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
