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

        private void button1_Click(object sender, EventArgs e)
        {
                                    
            var numeroDocumento = documentoTextBox.Text;

            var cv = new JornadaRule();
            cv.ComprobarVotante(numeroDocumento);

           
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
