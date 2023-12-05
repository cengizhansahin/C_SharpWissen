namespace TrenBiletiOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Guzergah> guzergahlar = new List<Guzergah>();
        List<BiletAl> biletler = new List<BiletAl>();

        private void btnOlustur_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(text_guzergahAdi.Text) && !string.IsNullOrWhiteSpace(text_guzergahFiyati.Text) && !string.IsNullOrWhiteSpace(text_koltukSayisi.Text))
            {
                string guzergahAdi = text_guzergahAdi.Text;
                int koltukSayisi = int.Parse(text_koltukSayisi.Text);
                double guzergahFiyati = double.Parse(text_guzergahFiyati.Text);
                guzergahlar.Add(new Guzergah(guzergahAdi, koltukSayisi, guzergahFiyati));
                text_bosKoltukSayisi.Text = guzergahlar[0].KoltukSayisi.ToString();
                text_toplamCiro.Text = "0";
                MessageBox.Show("Güzergah oluþturuldu.");
            }
            else
            {
                MessageBox.Show("Lütfen zorunlu alanlarý doldurun!");
            }
        }
        private void btnSat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(text_guzergahAdi.Text) && !string.IsNullOrWhiteSpace(text_guzergahFiyati.Text) && !string.IsNullOrWhiteSpace(text_koltukSayisi.Text))
            {
                double toplamFiyat = double.Parse(text_toplamCiro.Text);
                if (guzergahlar[0].KoltukSayisi > 0)
                {
                    biletler.Add(new BiletAl(guzergahlar[0], rBtnInrimli.Checked));
                    guzergahlar[0].KoltukSayisi--;
                    toplamFiyat += biletler[biletler.Count - 1].Fiyat;
                    text_bosKoltukSayisi.Text = guzergahlar[0].KoltukSayisi.ToString();
                    text_toplamCiro.Text = toplamFiyat.ToString();
                    btnIade.Enabled = true;
                }
                else
                {
                    btnSat.Enabled = false;
                }

                listBox1.Items.Clear();
                foreach (var item in biletler)
                {
                    listBox1.Items.Add($"Güzergah adý: {item.Guzergah.GuzergahAdi}, fiyatý: {item.Fiyat}");
                }
            }
            else
            {
                MessageBox.Show("Lütfen zorunlu alanlarý doldurun!");
            }
        }
        private void btnIade_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(text_guzergahAdi.Text) && !string.IsNullOrWhiteSpace(text_guzergahFiyati.Text) && !string.IsNullOrWhiteSpace(text_koltukSayisi.Text))
            {
                double toplamFiyat = double.Parse(text_toplamCiro.Text);

                if (biletler.Count > 0)
                {
                    BiletAl sonbilet = biletler[biletler.Count - 1];
                    toplamFiyat -= sonbilet.Fiyat;
                    biletler.Remove(sonbilet);
                    guzergahlar[0].KoltukSayisi++;

                    text_bosKoltukSayisi.Text = guzergahlar[0].KoltukSayisi.ToString();
                    text_toplamCiro.Text = toplamFiyat.ToString();
                    btnSat.Enabled = true;
                }
                else
                {
                    btnIade.Enabled = false;
                }
                listBox1.Items.Clear();
                foreach (var item in biletler)
                {
                    listBox1.Items.Add($"Güzergah adý: {item.Guzergah.GuzergahAdi}, fiyatý: {item.Fiyat}");
                }
            }
            else
            {
                MessageBox.Show("Lütfen zorunlu alanlarý doldurun!");
            }
        }
    }
    class Guzergah
    {
        public string GuzergahAdi { get; set; }
        public int KoltukSayisi { get; set; }
        public double GuzergahFiyati { get; set; }
        public Guzergah(string guzergahAdi, int koltukSayisi, double guzergahFiyati)
        {
            GuzergahAdi = guzergahAdi;
            KoltukSayisi = koltukSayisi;
            GuzergahFiyati = guzergahFiyati;
        }
    }
    class BiletAl
    {
        public Guzergah Guzergah { get; set; }
        public double Fiyat { get; set; }
        public BiletAl(Guzergah guzergah, bool indirimli)
        {
            Guzergah = guzergah;
            Fiyat = fiyatHesapla(indirimli, guzergah);
        }
        public double fiyatHesapla(bool indirimli, Guzergah guzergah)
        {
            if (indirimli)
            {
                return guzergah.GuzergahFiyati / 2;
            }
            else
            {
                return guzergah.GuzergahFiyati;
            }
        }
    }
}
