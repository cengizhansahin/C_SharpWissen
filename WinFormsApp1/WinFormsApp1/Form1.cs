namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<double> ogrenciOrtler = new List<double>();
        List<string> ogrenciAdlari = new List<string>();
        //ssdfsdf
        private void netHesaplaBtn_Click(object sender, EventArgs e)
        {
            double cd, cy, cn, od, oy, on, rd, ry, rn;

            cd = double.Parse(text_csharp_dogru.Text);
            cy = double.Parse(text_csharp_yanlis.Text);

            od = double.Parse(text_oop_dogru.Text);
            oy = double.Parse(text_oop_yanlis.Text);

            rd = double.Parse(text_react_dogru.Text);
            ry = double.Parse(text_react_yanlis.Text);

            cn = cd - 0.25 * cy;
            on = od - 0.25 * oy;
            rn = rd - 0.25 * ry;

            text_csharp_net.Text = cn.ToString();
            text_oop_net.Text = on.ToString();
            text_react_net.Text = rn.ToString();
        }

        private void tekciftBtn_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(text_tekcift.Text);
            if (sayi % 2 == 0)
            {
                MessageBox.Show($"{sayi} sayýsý çifttir");
            }
            else if (sayi % 2 == 1)
            {
                MessageBox.Show($"{sayi} sayýsý tektir");
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayý giriniz!");
            }
        }

        private void alanCevreBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(text_kk.Text) && (!string.IsNullOrWhiteSpace(text_uk.Text)))
            {
                double kk, uk;
                kk = double.Parse(text_kk.Text);
                uk = double.Parse(text_uk.Text);
                if (alanRadioBtn.Checked)
                {
                    double sonuc = kk * uk;
                    sonucLabel.Text = $"Sonuç: {sonuc.ToString()}";
                }
                else if (cevreRadioBtn.Checked)
                {
                    double sonuc = (kk + uk) * 2;
                    sonucLabel.Text = $"Sonuç: {sonuc.ToString()}";

                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir seçim yapýnýz!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurunuz!");
            }

        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            string ogrenciAdi = text_ogrenciAdi.Text;
            double ogrenciOrt = double.Parse(text_ogrenciOrt.Text);
            ogrenciAdlari.Add(ogrenciAdi);
            ogrenciOrtler.Add(ogrenciOrt);
        }

        private void tumunuListeleBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ogrenciAdlari.Count; i++)
            {
                listBox1.Items.Add($"{ogrenciAdlari[i]}\t{ogrenciOrtler[i]}");
            }
        }

        private void kalanlariListeleBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ogrenciAdlari.Count; i++)
            {
                if (ogrenciOrtler[i] < 50)
                {
                    listBox1.Items.Add($"{ogrenciAdlari[i]}\t{ogrenciOrtler[i]}");
                }
            }
        }

        private void gecenleriListeleBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ogrenciAdlari.Count; i++)
            {
                if (ogrenciOrtler[i] >= 50)
                {
                    listBox1.Items.Add($"{ogrenciAdlari[i]}\t{ogrenciOrtler[i]}");
                }
            }
        }

        private void tesekkurBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ogrenciAdlari.Count; i++)
            {
                if (ogrenciOrtler[i] >= 70 && ogrenciOrtler[i] < 85)
                {
                    listBox1.Items.Add($"{ogrenciAdlari[i]}\t{ogrenciOrtler[i]}");
                }
            }
        }

        private void takdirBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ogrenciAdlari.Count; i++)
            {
                if (ogrenciOrtler[i] >= 85)
                {
                    listBox1.Items.Add($"{ogrenciAdlari[i]}\t{ogrenciOrtler[i]}");
                }
            }
        }
    }
}
