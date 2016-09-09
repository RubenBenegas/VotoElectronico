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

        public Votante VotanteActual { get; set; }

        public JornadaElectoral JornadaActual { get; set; }

        private void VotacionForm_Load(object sender, EventArgs e)
        {
            var cm = new CandidatoMapper();
            candidatoBindingSource.DataSource = cm.ObtenerTodas();
        }


        private void votarButton_Click(object sender, EventArgs e)
        {
            
            var candidato = (Candidato) candidatoBindingSource.Current;

            var jr = new JornadaRule();
            jr.Votar(candidato, "001", VotanteActual, null); /*En null pasar la propiedad JornadaActual 
                                                               cuyo valor debe ser obtenido de una entidad JornadaElectoral*/

            
            MessageBox.Show("Su voto fue registrado con exito.");

            

            Close();

            var tf = new TicketForm();
            tf.Show();
            
        }

        
    }

}
    
