namespace final_çalışması_hesap_makinesi
{
    public partial class Form1 : Form
    {
        //Değişkenler
        private char _islem;
        double ilksayi, ikincisayi, sonuc;
        bool _ekran_temizle;
        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            //Eğer ekran temizleme işareti varsa ekranı temizle
            if (_ekran_temizle)
            {
                ekranLabel.Text = "";
                _ekran_temizle = false;
            }

            //Eğer ekranda 0 varsa sil
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            //1 rakamına tıklandığında ekrana 1 yaz
            ekranLabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            //Eğer ekran temizleme işareti varsa ekranı temizle
            if (_ekran_temizle)
            {
                ekranLabel.Text = "";
                _ekran_temizle = false;
            }

            //Eğer ekranda 0 varsa sil
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "2";
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            //Eğer ekran temizleme işareti varsa ekranı temizle
            if (_ekran_temizle)
            {
                ekranLabel.Text = "";
                _ekran_temizle = false;
            }

            //Eğer ekranda 0 varsa sil
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "3";
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            //Eğer ekran temizleme işareti varsa ekranı temizle
            if (_ekran_temizle)
            {
                ekranLabel.Text = "";
                _ekran_temizle = false;
            }

            //Eğer ekranda 0 varsa sil
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            //Eğer ekran temizleme işareti varsa ekranı temizle
            if (_ekran_temizle)
            {
                ekranLabel.Text = "";
                _ekran_temizle = false;
            }

            //Eğer ekranda 0 varsa sil
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            //Eğer ekran temizleme işareti varsa ekranı temizle
            if (_ekran_temizle)
            {
                ekranLabel.Text = "";
                _ekran_temizle = false;
            }

            //Eğer ekranda 0 varsa sil
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            //Eğer ekran temizleme işareti varsa ekranı temizle
            if (_ekran_temizle)
            {
                ekranLabel.Text = "";
                _ekran_temizle = false;
            }

            //Eğer ekranda 0 varsa sil
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            //Eğer ekran temizleme işareti varsa ekranı temizle
            if (_ekran_temizle)
            {
                ekranLabel.Text = "";
                _ekran_temizle = false;
            }

            //Eğer ekranda 0 varsa sil
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            //Eğer ekran temizleme işareti varsa ekranı temizle
            if (_ekran_temizle)
            {
                ekranLabel.Text = "";
                _ekran_temizle = false;
            }

            //Eğer ekranda 0 varsa sil
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            //Eğer ekran temizleme işareti varsa ekranı temizle
            if (_ekran_temizle)
            {
                ekranLabel.Text = "";
                _ekran_temizle = false;
            }

            //Eğer ekranda 0 varsa sil
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "0";
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            //ekranı temizle
            _ekran_temizle = true;
            //ilk sayıyı al
            ilksayi = Convert.ToDouble(ekranLabel.Text);
        }

        private void cıkarma_Click(object sender, EventArgs e)
        {
            _islem = '-';
            //ekranı temizle
            _ekran_temizle = true;
            //ilk sayıyı al
            ilksayi = Convert.ToDouble(ekranLabel.Text);
                    }

        private void carpma_button_Click(object sender, EventArgs e)
        {
            _islem = '*';
            //ekranı temizle
            _ekran_temizle = true;
            //ilk sayıyı al
            ilksayi = Convert.ToDouble(ekranLabel.Text);


        }

        private void bölme_button_Click(object sender, EventArgs e)
        {
            _islem = '/';
            //ekranı temizle
            _ekran_temizle = true;
            //ilk sayıyı al
            ilksayi = Convert.ToDouble(ekranLabel.Text);


        }

        private void esittir_button_Click(object sender, EventArgs e)
        {
            switch (_islem)
            {
                case '+':
                    ikincisayi = Convert.ToDouble(ekranLabel.Text);
                    sonuc = ilksayi + ikincisayi;
                    ekranLabel.Text = sonuc.ToString();
                    break;
                case '-':
                    ikincisayi = Convert.ToDouble(ekranLabel.Text);
                    sonuc = ilksayi - ikincisayi;
                    ekranLabel.Text = sonuc.ToString();
                    break;
                case '*':
                    ikincisayi = Convert.ToDouble(ekranLabel.Text);
                    sonuc = ilksayi * ikincisayi;
                    ekranLabel.Text = sonuc.ToString();
                    break;
                case '/':
                    ikincisayi = Convert.ToDouble(ekranLabel.Text);
                    sonuc = ilksayi / ikincisayi;
                    ekranLabel.Text = sonuc.ToString();
                    break;

            }
        }

        private void temizle_button_Click(object sender, EventArgs e)
        {
            //Ekranı temizle
            ekranLabel.Text = "0";
        }
    }
}
