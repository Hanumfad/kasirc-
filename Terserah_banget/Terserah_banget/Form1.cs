namespace Terserah_banget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbjenis.Items.Add("Kaos");
            cmbjenis.Items.Add("Celana");
            cmbjenis.Items.Add("Kemeja");

            cmbdiskon.Items.Add("5%");
            cmbdiskon.Items.Add("10%");
            cmbdiskon.Items.Add("15%");
            cmbdiskon.Items.Add("20%");
            cmbdiskon.Items.Add("25%");
            cmbdiskon.Items.Add("30%");
            cmbdiskon.Items.Add("35%");
        }

        private void cmbjenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbjenis.Text == "Kaos")
            {
                cmbnama.Items.Clear();
                cmbnama.Text = "";
                cmbnama.Items.Add("Kaos lengan panjang putih L");
                cmbnama.Items.Add("Kaos lengan panjang hitam M");
                cmbnama.Items.Add("Kaos lengan pendek putih L");
                cmbnama.Items.Add("Kaos lengan pendek hitam M");
            }
            else if (cmbjenis.Text == "Celana")
            {
                cmbnama.Items.Clear();
                cmbnama.Text = "";
                cmbnama.Items.Add("Celana Kulot");
                cmbnama.Items.Add("Celana Jeans");
                cmbnama.Items.Add("Celana Legging");
                cmbnama.Items.Add("Celana Joger");

            }
            else if (cmbjenis.Text == "Kemeja")
            {
                cmbnama.Items.Clear();
                cmbnama.Text = "";
                cmbnama.Items.Add("Kemeja Denim");
                cmbnama.Items.Add("Kemeja Batik");
                cmbnama.Items.Add("Kemeja Polos Hitam");
                cmbnama.Items.Add("Kemeja Polos Putih");

            }
            else
            {
                Console.WriteLine("Item tidak ditemukan");
            }

        }

        private void cmbnama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbnama.Text == "Kaos lengan panjang putih L")
            {
                txtstok.Text = "12";
                txtharga.Text = "87000";
            }
            else if (cmbnama.Text == "Kaos lengan panjang hitam M")
            {
                txtstok.Text = "7";
                txtharga.Text = "87000";
            }
            else if (cmbnama.Text == "Kaos lengan pendek hitam M")
            {
                txtstok.Text = "9";
                txtharga.Text = "77000";
            }
            else if (cmbnama.Text == "Kaos lengan pendek putih L")
            {
                txtstok.Text = "5";
                txtharga.Text = "77000";
            }
            else if (cmbnama.Text == "Celana Kulot")
            {
                txtstok.Text = "4";
                txtharga.Text = "67000";
            }
            else if (cmbnama.Text == "Celana Jeans")
            {
                txtstok.Text = "8";
                txtharga.Text = "105000";
            }
            else if (cmbnama.Text == "Celana Legging")
            {
                txtstok.Text = "17";
                txtharga.Text = "47000";
            }
            else if (cmbnama.Text == "Celana Joger")
            {
                txtstok.Text = "20";
                txtharga.Text = "95000";
            }
            else if (cmbnama.Text == "Kemeja Denim")
            {
                txtstok.Text = "4";
                txtharga.Text = "269000";
            }
            else if (cmbnama.Text == "Kemeja Batik")
            {
                txtstok.Text = "14";
                txtharga.Text = "229000";
            }
            else if (cmbnama.Text == "Kemeja Polos Hitam")
            {
                txtstok.Text = "25";
                txtharga.Text = "99000";
            }
            else if (cmbnama.Text == "Kemeja Polos Putih")
            {
                txtstok.Text = "19";
                txtharga.Text = "97000";
            }
            else
            {
                Console.WriteLine("Item tidak ditemukan");
            }
        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
            double jumlah;
            if (double.TryParse(numjumlah.Text, out jumlah))
            {
                double harga = Convert.ToDouble(txtharga.Text);
                double uang = Convert.ToDouble(numuang.Text);
                double totalharga = Math.Round(harga * jumlah);
                double diskonPercentage = Convert.ToDouble(cmbdiskon.Text.Trim('%')) / 100;
                double diskon = Math.Round(totalharga * diskonPercentage);
                double totalBayar = totalharga - diskon;
                double kembalian = uang - totalBayar;

                if (kembalian >= 0)
                {
                    txtkembalian.Text = kembalian.ToString();
                }
                else
                {
                    MessageBox.Show("Uang bayar kurang!");
                }

                txttotalbayar.Text = totalBayar.ToString();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbjenis.SelectedIndex = -1;
            cmbnama.SelectedIndex = -1;
            cmbnama.Items.Clear();
            txtstok.Text = "";
            txtharga.Text = "";
            numjumlah.Text = "";
            txttotalharga.Text = "";
            cmbdiskon.Text = "";
            txttotalbayar.Text = "";
            numuang.Text = "";
            txtkembalian.Text = "";
            Form1_Load(sender, e);
        }

        private void btnbtl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txttotalharga_Click(object sender, EventArgs e)
        {
           
        }

        private void numjumlah_ValueChanged(object sender, EventArgs e)
        {
            double jumlah;
            if (double.TryParse(numjumlah.Text, out jumlah))
            {
                double harga = Convert.ToDouble(txtharga.Text);
                double totalharga = Math.Round(harga * jumlah);

                txttotalharga.Text = totalharga.ToString();

            }
        }

        private void cmbdiskon_SelectedIndexChanged(object sender, EventArgs e)
        {
            double jumlah;
            if (double.TryParse(numjumlah.Text, out jumlah))
            {
                double harga = Convert.ToDouble(txtharga.Text);
                double uang = Convert.ToDouble(numuang.Text);
                double totalharga = Math.Round(harga * jumlah);
                double diskonPercentage = Convert.ToDouble(cmbdiskon.Text.Trim('%')) / 100;
                double diskon = Math.Round(totalharga * diskonPercentage);
                double totalBayar = totalharga - diskon;
              
                cmbdiskon.Text = diskon.ToString();
                txttotalbayar.Text = totalBayar.ToString();
            }
        }
    }
}