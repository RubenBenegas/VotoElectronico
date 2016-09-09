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
    public partial class JornadaGridForm : Form
    {
        public JornadaGridForm()
        {
            InitializeComponent();
        }
        
        private void salirButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void JornadaGridForm_Load(object sender, EventArgs e)
        {
            var jm = new JornadaMapper();
            jornadaElectoralBindingSource.DataSource = jm.ObtenerTodas();
        }

        private void jornadaElectoralBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var jm = new JornadaMapper();

            var datos = (IEnumerable<JornadaElectoral>)jornadaElectoralBindingSource.DataSource;

            jm.EliminarTodas();

            jm.Grabar(datos);
        }

        private void jornadaElectoralDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var jf = new JornadaForm();
            jf.jornadaElectoralBindingSource.DataSource = jornadaElectoralBindingSource.Current;
            jf.ShowDialog();

            jornadaElectoralDataGridView.Refresh();
        }
    }
}
