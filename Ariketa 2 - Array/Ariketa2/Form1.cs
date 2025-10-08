using System.Diagnostics.Metrics;

namespace Ariketa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Eragiketa eragiketa = new Eragiketa();
        int clickCounter = 0;

        private void btnHurrengoa_Click(object sender, EventArgs e)
        {
            clickCounter++;
            int pos = 0;
            switch (clickCounter)
            {
                case 1:
                    {
                        eragiketa.Zenbakiak[pos] = float.Parse(tbZenbakia.Text);
                        pos++;
                        labelEguneratu();
                        break;
                    }
                case 2:
                    {
                        eragiketa.Zenbakiak[pos] = float.Parse(tbZenbakia.Text);
                        pos++;
                        labelEguneratu();
                        break;
                    }
                case 3:
                    {
                        eragiketa.Zenbakiak[pos] = float.Parse(tbZenbakia.Text);
                        pos++;
                        labelEguneratu();
                        break;
                    }
                case 4:
                    {
                        eragiketa.Zenbakiak[pos] = float.Parse(tbZenbakia.Text);
                        btnHurrengoa.Enabled = false;   
                        lbZenbakia.Text = "Emaitza";
                        tbZenbakia.Clear();
                        tbZenbakia.ReadOnly = true;
                        //tbZenbakia.Text = eragiketa.SetFormula();
                        break;
                    }
            }
        }

        private void labelEguneratu()
        {
            lbZenbakia.Text = $"{clickCounter + 1}. zenbakia";
            tbZenbakia.Clear();
        }
        
        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            clickCounter = 0;
            lbZenbakia.Text = "1. zenbakia";
            tbZenbakia.Clear();
            tbZenbakia.ReadOnly = false;
            btnHurrengoa.Enabled = true;
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
