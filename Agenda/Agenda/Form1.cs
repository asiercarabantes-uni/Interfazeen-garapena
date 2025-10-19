using GrafikoaDll;
using KontaktuLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Agenda
{
    public partial class Form1 : Form
    {

        private List<Kontaktua> agenda = new List<Kontaktua>();

        public Form1()
        {
            InitializeComponent();

            Kontaktua kontaktua1 = new Kontaktua("Josu", "Cabrera", "634567092", "Emakumea", "+34");
            Kontaktua kontaktua2 = new Kontaktua("Asier", "Carabantes", "662153045", "Gizona", "+34");
            Kontaktua kontaktua3 = new Kontaktua("Martin", "Villalon", "692015299", "Ez-bitarra", "+43");

            agenda.Add(kontaktua1);
            agenda.Add(kontaktua2);
            agenda.Add(kontaktua3);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generoGrafikoaEguneratu();
            prefijoGrafikoaEguneratu();
        }

        private void btnGorde(object sender, EventArgs e)
        {
            Kontaktua kontaktua = new Kontaktua(
                tbIzena.Text,
                tbAbizena.Text,
                tbTelefonoa.Text,
                cbGeneroa.Text,
                tbPrefijoa.Text
                );

            Kontaktua.gordeKontaktua(kontaktua, agenda);

            tbIzena.Text = "";
            tbAbizena.Text = "";
            tbTelefonoa.Text = "";
            cbGeneroa.Text = "";
            tbPrefijoa.Text = "";

            generoGrafikoaEguneratu();
            prefijoGrafikoaEguneratu();
        }

        private void btnIkusi(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = agenda;
        }

        private void btnBilatu(object sender, EventArgs e)
        {
            List<Kontaktua> results = new List<Kontaktua>();

            foreach (Kontaktua kontaktua in agenda)
            {
                if (kontaktua.Telefonoa == tbBilatu.Text)
                {
                    results.Add(kontaktua);
                }
            }

            dataGridView.DataSource = null;
            dataGridView.DataSource = results;
        }

        private void generoGrafikoaEguneratu()
        {
            int gizonak = agenda.FindAll(kontaktua => kontaktua.Generoa == "Gizona").Count;
            int emakumeak = agenda.FindAll(kontaktua => kontaktua.Generoa == "Emakumea").Count;
            int ezBitarrak = agenda.FindAll(kontaktua => kontaktua.Generoa == "Ez-bitarra").Count;

            var datuak = new List<(string generoa, int kantitatea)>
            {
                ("Gizonak", gizonak),
                ("Emakumeak", emakumeak),
                ("Ez-bitarrak", ezBitarrak)
            };

            grafikoa1.UpdateData(
                    datuak,
                    d => d.generoa,
                    d => d.kantitatea,
                    SeriesChartType.Pie
            );
        }

        private void prefijoGrafikoaEguneratu()
        {
            var datosPrefijo = agenda
                .GroupBy(k => k.Prefijoa)
                .Select(g => new { Prefijo = g.Key, Cantidad = g.Count() })
                .ToList();

            var listaDatos = datosPrefijo
                .Select(d => (etiqueta: d.Prefijo, valor: (double)d.Cantidad))
                .ToList();

            grafikoa2.UpdateData(
                listaDatos,
                d => d.etiqueta,
                d => d.valor,
                SeriesChartType.Column 
            );
        }

    }
}
