﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Reglas;

namespace VotoElectronicoBeta
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jf = new JornadaForm();
            jf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nuevoPadron = new List<Votante>();
            var cv = new JornadaRule();
            cv.CargarVotantes(nuevoPadron);

            var idenf = new IdentificacionForm();
            idenf.Show();
        }

        private void agregarCandidatoButton_Click(object sender, EventArgs e)
        {
            var cgf = new CandidatoGridForm();
            cgf.Show();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var jr2 = new JornadaRule();
            jr2.ObtenerResultado(); 


        }
    }
}
