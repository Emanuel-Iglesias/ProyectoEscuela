using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEscuela
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tbCursoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbCursoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdEscuelaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdEscuelaDataSet.tbEstudiante' Puede moverla o quitarla según sea necesario.
            this.tbEstudianteTableAdapter.Fill(this.bdEscuelaDataSet.tbEstudiante);
            // TODO: esta línea de código carga datos en la tabla 'bdEscuelaDataSet.tbGrado' Puede moverla o quitarla según sea necesario.
            this.tbGradoTableAdapter.Fill(this.bdEscuelaDataSet.tbGrado);
            // TODO: esta línea de código carga datos en la tabla 'bdEscuelaDataSet.tbCurso' Puede moverla o quitarla según sea necesario.
            this.tbCursoTableAdapter.Fill(this.bdEscuelaDataSet.tbCurso);

        }
    }
}
