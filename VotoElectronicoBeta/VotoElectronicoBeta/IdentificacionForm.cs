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
    public partial class IdentificacionForm : Form
    {
        
        

        public IdentificacionForm()
        {
           
            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
                                    
            var numeroDocumentoABuscar = documentoTextBox.Text;

            var cv = new JornadaRule();
            var votante= cv.ComprobarVotante(numeroDocumentoABuscar);

            if(votante == null)
            {
                MessageBox.Show("El votante no existe");
                return;

            }

            var vf = new VotacionForm();
            vf.Show();
           
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}