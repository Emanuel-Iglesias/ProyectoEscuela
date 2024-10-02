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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdEscuelaDataSet1.tbGrado' Puede moverla o quitarla según sea necesario.
            this.tbGradoTableAdapter.Fill(this.bdEscuelaDataSet1.tbGrado);
            // TODO: esta línea de código carga datos en la tabla 'bdEscuelaDataSet1.tbEstudiante' Puede moverla o quitarla según sea necesario.
            this.tbEstudianteTableAdapter.Fill(this.bdEscuelaDataSet1.tbEstudiante);
            // TODO: esta línea de código carga datos en la tabla 'bdEscuelaDataSet1.tbCurso' Puede moverla o quitarla según sea necesario.
            this.tbCursoTableAdapter.Fill(this.bdEscuelaDataSet1.tbCurso);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresarGrado_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdGradoGrado.Text);
                String nombre = txtNombreGrado.Text;
                this.tbGradoTableAdapter.insertarGrado(id, nombre);
                MessageBox.Show("Datos Ingresador Correctamente");
                this.tbGradoTableAdapter.Fill(this.bdEscuelaDataSet1.tbGrado);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnActualizarGrado_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdGradoGrado.Text);
                String nombre = txtNombreGrado.Text;
                this.tbGradoTableAdapter.actualizarGrado(nombre,id);
                MessageBox.Show("Datos Actualizados Correctamente");
                this.tbGradoTableAdapter.Fill(this.bdEscuelaDataSet1.tbGrado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarGrado_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdGradoGrado.Text);
                this.tbGradoTableAdapter.eliminarGrado(id);
                MessageBox.Show("Datos Eliminados Correctamente");
                this.tbGradoTableAdapter.Fill(this.bdEscuelaDataSet1.tbGrado);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIngresarCursos_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdCursoCursos.Text);
                String nombre = txtNombreCurso.Text;
                int id2 = Convert.ToInt32(txtIdGradoCursos.Text);
                this.tbCursoTableAdapter.insertarCurso(id, nombre, id2);
                MessageBox.Show("Datos Ingresador Correctamente");
                this.tbCursoTableAdapter.Fill(this.bdEscuelaDataSet1.tbCurso);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizarCursos_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdCursoCursos.Text);
                String nombre = txtNombreCurso.Text;
                int id2 = Convert.ToInt32(txtIdGradoCursos.Text);
                this.tbCursoTableAdapter.actualizarCurso(nombre, id2,id);
                MessageBox.Show("Datos Actualizados Correctamente");
                this.tbCursoTableAdapter.Fill(this.bdEscuelaDataSet1.tbCurso);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarCursos_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdCursoCursos.Text);
                this.tbCursoTableAdapter.eliminarCurso(id);
                MessageBox.Show("Datos Eliminados Correctamente");
                this.tbCursoTableAdapter.Fill(this.bdEscuelaDataSet1.tbCurso);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIngresarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdEstudiante.Text);
                String nombre = txtNombreEstudiante.Text;
                String apellido = txtApellidoEstudiante.Text;
                int edad = Convert.ToInt32(txtEdadEstudiante.Text);
                int id2 = Convert.ToInt32(txtIdCursoEstudiante.Text);
                int id3 = Convert.ToInt32(txtIdGradoEstudiante.Text);
                this.tbEstudianteTableAdapter.insertarEstudiante(id, nombre, apellido, edad, id2, id3);
                MessageBox.Show("Datos Ingresador Correctamente");
                this.tbEstudianteTableAdapter.Fill(this.bdEscuelaDataSet1.tbEstudiante);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdEstudiante.Text);
                String nombre = txtNombreEstudiante.Text;
                String apellido = txtApellidoEstudiante.Text;
                int edad = Convert.ToInt32(txtEdadEstudiante.Text);
                int id2 = Convert.ToInt32(txtIdCursoEstudiante.Text);
                int id3 = Convert.ToInt32(txtIdGradoEstudiante.Text);
                this.tbEstudianteTableAdapter.actualizarEstudiante(nombre, apellido, edad, id2,id3,id);
                MessageBox.Show("Datos Actualizados Correctamente");
                this.tbEstudianteTableAdapter.Fill(this.bdEscuelaDataSet1.tbEstudiante);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdEstudiante.Text);
                this.tbEstudianteTableAdapter.eliminarEstudiante(id);
                MessageBox.Show("Datos Eliminados Correctamente");
                this.tbEstudianteTableAdapter.Fill(this.bdEscuelaDataSet1.tbEstudiante);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
