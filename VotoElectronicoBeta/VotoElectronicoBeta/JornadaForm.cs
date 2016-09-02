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
    public partial class JornadaForm : Form
    {
        public JornadaForm()
        {

            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            var nuevaJornada = new JornadaElectoral
            {
                Nombre = nombreTextBox.Text,
                Fecha = fechaTextBox.Text,
                HoraComienzo = horaComienzoTextBox.Text,
                HoraFin = horaFinTextBox.Text,
                Organizador = organizadorTextBox.Text,
            };

            var g = new JornadaMapper();
            g.Grabar(nuevaJornada);

            Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cf = new CandidatoForm();
            cf.Show();
        }

       
    }
}
