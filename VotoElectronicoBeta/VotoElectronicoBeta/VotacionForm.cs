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
            jr.Votar(candidato, "001", VotanteActual, null);

            var jr2 = new JornadaRule();
            jr2.ObtenerResultado(candidato);

            MessageBox.Show("Su voto fue registrado con exito.");

            ImprimirTicket();

            Close();
            
        }

        private void ImprimirTicket()

        {
            var path = System.Windows.Forms.Application.StartupPath;

            Bitmap imagen;
            Graphics g = this.CreateGraphics();
            Size s = this.Size;
            imagen = new Bitmap(s.Width, s.Height, g);
            Graphics g2 = Graphics.FromImage(imagen);
            g2.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            imagen.Save(path + "\\" + "imagen.jPEG");

        }
    }

}
    
