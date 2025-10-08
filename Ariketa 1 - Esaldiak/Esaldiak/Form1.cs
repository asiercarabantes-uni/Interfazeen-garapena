namespace Esaldiak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Esaldia esaldia = new Esaldia();
 

        private void btnEsaldi1_Click(object sender, EventArgs e)
        {
            esaldia.SetEsaldiaBatuta(tbHitza.Text.ToString());
            btnEsaldi2.Enabled = true;
            btnEsaldi1.Enabled = false;
            tbHitza.Clear();
        }

        private void btnEsaldi2_Click(object sender, EventArgs e)
        {
            esaldia.SetEsaldiaBatuta(tbHitza.Text.ToString());
            btnEsaldi3.Enabled = true;
            btnEsaldi2.Enabled = false;
            tbHitza.Clear();
        }

        private void btnEsaldi3_Click(object sender, EventArgs e)
        {
            esaldia.SetEsaldiaBatuta(tbHitza.Text.ToString());
            btnEsaldi4.Enabled = true;
            btnEsaldi3.Enabled = false;
            tbHitza.Clear();
        }

        private void btnEsaldi4_Click(object sender, EventArgs e)
        {
            esaldia.SetEsaldiaBatuta(tbHitza.Text.ToString());
            btnEsaldi5.Enabled = true;
            btnEsaldi4.Enabled = false;
            tbHitza.Clear();
        }

        private void btnEsaldi5_Click(object sender, EventArgs e)
        {
            esaldia.SetEsaldiaBatuta(tbHitza.Text.ToString());
            btnLotu.Enabled = true;
            btnEsaldi5.Enabled = false;
            tbHitza.Clear();
        }

        private void btnLotu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(esaldia.esaldiaBatuta);
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            esaldia.esaldiaBatuta = "";
            tbHitza.Clear();
            btnEsaldi1.Enabled = true;
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;
            btnLotu.Enabled = false;
        }
    }
}
