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


namespace VotoElectronicoBeta
{
    public partial class VotacionForm : Form
    {
        public VotacionForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_Load(object sender, DataGridViewCellEventArgs e)
        {
            var nuevosCandidatos = new Candidato();

            dataGridView1.Rows.Add(nuevosCandidatos.Apellido, nuevosCandidatos.Nombre, nuevosCandidatos.Partido, nuevosCandidatos.Slogan);
        }
    }
}
