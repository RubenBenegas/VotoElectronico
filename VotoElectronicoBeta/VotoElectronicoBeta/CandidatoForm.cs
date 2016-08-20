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

namespace VotoElectronicoBeta
{
    public partial class CandidatoForm : Form
    {

        private List<Candidato> _candidatos;

        public CandidatoForm()
        {
            _candidatos = new List<Candidato>();

            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            var c = new Candidato();
            c.Codigo = codigoTextBox.Text;
            c.Apellido = apellidoTextBox.Text;
            c.Nombre = nombreTextBox.Text;
            c.Partido = partidoTextBox.Text;
            c.Slogan = sloganTextBox.Text;

            var nuevoCandidato = new 

        //    _candidatos.Add(c);

        //    Close();
        }
    }
}
