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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            var c = new Candidato
            {
                Nombre = "Ruben",
                Apellido = "Benegas",
                Partido = "Cambiemos",
                Slogan = "Vamos que se puede"
            };

            var g = new CandidatoMapper();
            g.Grabar(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var r = new CandidatoMapper();

            var ruben = r.ObtenerTodas().First(); 

            MessageBox.Show(ruben.Id.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var c = new Candidato
            {
                Nombre = "Ruben",
                Apellido = "Benegas",
                Partido = "Cambiemos",
                Slogan = "Vamos que se puede"
            };

            var g = new CandidatoMapper();
            g.Grabar(c);

            var c2 = new Candidato
            {
                Nombre = "Mirna",
                Apellido = "Carreño",
                Partido = "Peronista",
                Slogan = "Hasta la victoria siempre"
            };

            
            g.Grabar(c2);
        }
    }
}
