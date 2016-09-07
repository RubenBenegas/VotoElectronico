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
    public partial class VotacionForm : Form
    {
        public VotacionForm()
        {
            InitializeComponent();
        }

        
        private void VotacionForm_Load(object sender, EventArgs e)
        {
            var cm = new CandidatoMapper();
            candidatoBindingSource.DataSource = cm.ObtenerTodas();
        }


        private void votarButton_Click(object sender, EventArgs e)
        {
            var nuevoCandidato = new Candidato();

            nuevoCandidato = (Candidato)candidatoBindingSource.Current;           

            var vc = new JornadaRule();
            vc.Votar(nuevoCandidato);

            var g = new CandidatoMapper();
            g.Grabar(nuevoCandidato);

            MessageBox.Show("Su voto fue registrado con exito.");

            Close();

            var rf = new ResultadoForm();
            rf.Show();
        }
    }
}
