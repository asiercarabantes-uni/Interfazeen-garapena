﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaixoDll;

namespace KaixoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMezua_Click(object sender, EventArgs e)
        {
            Kaixo kaixo = new Kaixo();
            MessageBox.Show(kaixo.MezuaIkusi());
        }
    }
}
