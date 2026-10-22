using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyect_Person
{
    public partial class Form1 : Form
    {
        db_igmr db = new db_igmr();
        int idSeleccionado = 0;

        public Form1()
        {
            InitializeComponent();

            if (comSELECCIONAR.Items.Count == 0)
            {
                comSELECCIONAR.Items.Add("Docente");
                comSELECCIONAR.Items.Add("Estudiante");
                comSELECCIONAR.Items.Add("Persona");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            db.BuscarPersonas(dataGridView1);
        }

        private void LimpiarCampos()
        {
            txtCEDULA.Text = "";
            txtNOMBRE.Text = "";
            txtANIO.Text = "";
            comSELECCIONAR.SelectedIndex = -1;
            idSeleccionado = 0;
        }

        private void btnINSERT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCEDULA.Text) || string.IsNullOrWhiteSpace(txtNOMBRE.Text) || string.IsNullOrWhiteSpace(txtANIO.Text))
            {
                MessageBox.Show("Por favor complete la cédula, el nombre y el año de nacimiento.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtANIO.Text, out int anioNacimiento))
            {
                MessageBox.Show("El año de nacimiento debe ser un número válido.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comSELECCIONAR.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una opción (Docente, Estudiante o Persona).", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoSeleccionado = comSELECCIONAR.SelectedItem.ToString();
            string cedula = txtCEDULA.Text;
            string nombre = txtNOMBRE.Text;

            if (tipoSeleccionado == "Docente")
            {
                // Creamos el objeto Docente con los datos base de la Persona
                Docente doc = new Docente();
                doc.Dni = cedula;
                doc.Name = nombre;
                doc.YearBirth = anioNacimiento;

                // Abrimos el Form2 (Docente) pasándole los datos base
                this.Hide();
                Form2 formDocente = new Form2(doc);
                formDocente.ShowDialog();
                this.Show();
                LimpiarCampos();
                CargarDatos();
            }
            else if (tipoSeleccionado == "Estudiante")
            {
                // Creamos el objeto Estudiante con los datos base de la Persona
                Estudiante est = new Estudiante();
                est.Dni = cedula;
                est.Name = nombre;
                est.YearBirth = anioNacimiento;

                // Abrimos el Form3 (Estudiante) pasándole los datos base
                this.Hide();
                Form3 formEstudiante = new Form3(est);
                formEstudiante.ShowDialog();
                this.Show();
                LimpiarCampos();
                CargarDatos();
            }
            else if (tipoSeleccionado == "Persona")
            {
                // Registro directo de Persona en la base de datos
                Persona per = new Persona();
                per.Dni = cedula;
                per.Name = nombre;
                per.YearBirth = anioNacimiento;

                int res = db.AgregarPersona(per);
                if (res > 0)
                {
                    MessageBox.Show("Persona registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Error al registrar la persona en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                idSeleccionado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                txtCEDULA.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
                txtNOMBRE.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
                txtANIO.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
                string tipo = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";
                if (comSELECCIONAR.Items.Contains(tipo))
                {
                    comSELECCIONAR.SelectedItem = tipo;
                }
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Por favor seleccione una persona de la tabla para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCEDULA.Text) || string.IsNullOrWhiteSpace(txtNOMBRE.Text) || !int.TryParse(txtANIO.Text, out int anio))
            {
                MessageBox.Show("Por favor complete los campos correctamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Persona p = new Persona(idSeleccionado, txtCEDULA.Text, txtNOMBRE.Text, anio);
            if (db.ActualizarPersona(p) > 0)
            {
                MessageBox.Show("Persona actualizada correctamente.", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Por favor seleccione una persona de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar esta persona? Se eliminarán también sus registros asociados.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (db.EliminarPersona(idSeleccionado) > 0)
                {
                    MessageBox.Show("Persona eliminada correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
