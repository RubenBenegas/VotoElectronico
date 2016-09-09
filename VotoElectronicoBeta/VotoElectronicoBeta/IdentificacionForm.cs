using System;
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

            var nombreABuscar = nombreTextBox.Text;

            var oj = new JornadaRule();
            var jornada = oj.ObtenerJornada(nombreABuscar);

            if (jornada == null)
            {
                MessageBox.Show("La jornada con ese nombre no existe.");
            }

            var numeroDocumentoABuscar = documentoTextBox.Text;

            var cv = new JornadaRule();
            var votante= cv.ComprobarVotante(numeroDocumentoABuscar);

            if(votante == null)
            {

                MessageBox.Show("La persona con este DNI no forma parte del padron.");
                return;

            }

            Close();

            var vf = new VotacionForm();
            vf.VotanteActual = votante;
            vf.JornadaActual = jornada;
            vf.Show();
           
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
