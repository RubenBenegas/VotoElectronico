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
    public partial class CandidatoGridForm : Form
    {
        public CandidatoGridForm()
        {
            InitializeComponent();
        }

        private void CandidatoGridForm_Load(object sender, EventArgs e)
        {
            // Cuando cargamos el formulario obtenemos los datos.

            var cm = new CandidatoMapper();
            candidatoBindingSource.DataSource = cm.ObtenerTodas();
        }

        private void candidatoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var cm = new CandidatoMapper();

            // Obtenemos la referencia a los datos a grabar desde el datasource
            var datos = (IEnumerable<Candidato>) candidatoBindingSource.DataSource;

            // Mandamos a eliminar todos, por las dudas hayan borrado uno
            cm.EliminarTodas();
            // Grabamos todos los datos que estan enlazados a la grilla
            cm.Grabar(datos);
        }

        private void candidatoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cuando hacen doble click sobre la grilla, enlazamos el item actual al formulario
            var cf = new CandidatoForm();
            cf.candidatoBindingSource.DataSource = candidatoBindingSource.Current; // El current nos da el objeto que esta seleccionado
            cf.ShowDialog();
        }

        
    }
}
