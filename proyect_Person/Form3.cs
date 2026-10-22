using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyect_Person
{
    public partial class Form3 : Form
    {
        db_igmr db = new db_igmr();
        Estudiante estudianteActual = new Estudiante(); 
        int idSeleccionado = 0;

        public Form3(Estudiante e)
        {
            InitializeComponent();
            estudianteActual = e;
            db.BuscarEstudiantes(dataEstudiante); 
        }

        public Form3()
        {
            InitializeComponent();
            db.BuscarEstudiantes(dataEstudiante);
        }

        private void btnINSERTD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNOTA1.Text) || string.IsNullOrWhiteSpace(txtNOTA2.Text))
            {
                MessageBox.Show("Por favor complete los campos de Nota 1 y Nota 2.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Reemplazamos la coma por un punto para que sea compatible con la base de datos
                estudianteActual.Nota1 = double.Parse(txtNOTA1.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                estudianteActual.Nota2 = double.Parse(txtNOTA2.Text.Replace(',', '.'), CultureInfo.InvariantCulture);

                int resultado = db.AgregarEstudiante(estudianteActual);

                if (resultado > 0)
                {
                    MessageBox.Show("Estudiante registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.BuscarEstudiantes(dataEstudiante);

                    txtNOTA1.Text = "";
                    txtNOTA2.Text = "";
                }
                else
                {
                    MessageBox.Show("Error al registrar el estudiante en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor verifique que las notas ingresadas sean números válidos. Detalle: " + ex.Message, "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUPDATED_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Por favor seleccione un estudiante de la tabla para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNOTA1.Text) || string.IsNullOrWhiteSpace(txtNOTA2.Text))
            {
                MessageBox.Show("Por favor complete los campos de Nota 1 y Nota 2.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Asignamos el ID que guardamos al hacer clic en la grilla
                estudianteActual.Id = idSeleccionado;
                estudianteActual.Nota1 = double.Parse(txtNOTA1.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                estudianteActual.Nota2 = double.Parse(txtNOTA2.Text.Replace(',', '.'), CultureInfo.InvariantCulture);

                if (db.ActualizarEstudiante(estudianteActual) > 0)
                {
                    MessageBox.Show("Estudiante actualizado correctamente.", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.BuscarEstudiantes(dataEstudiante);
                    idSeleccionado = 0; // Reiniciamos la selección
                    txtNOTA1.Text = "";
                    txtNOTA2.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor verifique que las notas ingresadas sean números válidos. Detalle: " + ex.Message, "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDELETED_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Por favor seleccione un estudiante de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este estudiante?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Eliminamos usando el ID de la persona seleccionada en la grilla
                if (db.EliminarEstudiante(idSeleccionado) > 0)
                {
                    MessageBox.Show("Estudiante eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.BuscarEstudiantes(dataEstudiante);
                    idSeleccionado = 0; // Reiniciamos la selección
                    txtNOTA1.Text = "";
                    txtNOTA2.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dataEstudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataEstudiante.Rows[e.RowIndex].Cells[0].Value != null) 
            { 
                idSeleccionado = Convert.ToInt32(dataEstudiante.Rows[e.RowIndex].Cells[0].Value);
                // Las celdas 3 y 4 corresponden a NOTA1 y NOTA2 (0: ID, 1: Nombre, 2: Cedula, 3: Nota1, 4: Nota2)
                txtNOTA1.Text = dataEstudiante.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
                txtNOTA2.Text = dataEstudiante.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";
            }
        }

        private void dataEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataEstudiante_CellClick(sender, e);
        }
    }
}
