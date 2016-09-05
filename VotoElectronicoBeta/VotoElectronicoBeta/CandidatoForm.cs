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
    public partial class CandidatoForm : Form
    {
        public CandidatoForm()
        {
            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {

            

            var nuevoCandidato =new Candidato            
            {
                Apellido = apellidoTextBox.Text,
                Nombre = nombreTextBox.Text,
                Partido = partidoTextBox.Text,
                Slogan = sloganTextBox.Text,
            };

                    

            nuevoCandidato = (Candidato)candidatoBindingSource.Current;

            var ac = new JornadaRule();
            ac.AgregarCandidato(nuevoCandidato);

            var g = new CandidatoMapper();
            g.Grabar(nuevoCandidato);



            //var r = new CandidatoMapper();
            //var candidatoRecu = r.ObtenerTodas().FirstOrDefault();

            //dataGridView1.Rows.Add(nuevoCandidato.Apellido, nuevoCandidato.Nombre, nuevoCandidato.Partido, nuevoCandidato.Slogan);

                        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CandidatoForm_Load(object sender, EventArgs e)
        {
            candidatoBindingSource.DataSource = new Candidato();
        }
    }
}
