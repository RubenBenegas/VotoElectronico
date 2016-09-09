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
    public partial class ResultadoForm : Form
    {
        public ResultadoForm()
        {
            InitializeComponent();
        }

        private void ResultadoForm_Load(object sender, EventArgs e)
        {

            var res= new JornadaRule();
            res.ObtenerResultado();

            

            resultadoJornadaBindingSource.DataSource = res.ObtenerResultado(); 
        }

       
    }
}
