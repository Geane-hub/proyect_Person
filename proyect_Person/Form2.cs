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
    public partial class Form2 : Form
    {
        db_igmr db = new db_igmr();
        Docente docenteActual = new Docente();
        int idSeleccionado = 0;

        public Form2(Docente d)
        {
            InitializeComponent();
            docenteActual = d;
            db.BuscarDocentes(dataDocente);
        }

        public Form2()
        {
            InitializeComponent();
            db.BuscarDocentes(dataDocente);
        }

        private void dataDocente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataDocente.Rows[e.RowIndex].Cells[0].Value != null)
            {
                idSeleccionado = Convert.ToInt32(dataDocente.Rows[e.RowIndex].Cells[0].Value);
                txtTITULO.Text = dataDocente.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
                txtSALARIO.Text = dataDocente.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";
            }
        }

        private void dataDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataDocente_CellClick(sender, e);
        }

        private void btnINSERTD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTITULO.Text) || string.IsNullOrWhiteSpace(txtSALARIO.Text))
            {
                MessageBox.Show("Por favor complete los campos de Título y Sueldo.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                docenteActual.Titulo = txtTITULO.Text;
                docenteActual.Sueldo = double.Parse(txtSALARIO.Text.Replace(',', '.'), CultureInfo.InvariantCulture);

                // Guardamos en la base de datos
                int resultado = db.AgregarDocente(docenteActual);

                if (resultado > 0)
                {
                    MessageBox.Show("Docente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.BuscarDocentes(dataDocente); // Refresca la grilla

                    // Limpiar campos después de insertar
                    txtTITULO.Text = "";
                    txtSALARIO.Text = "";
                }
                else
                {
                    MessageBox.Show("Error al registrar el docente en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor verifique que el sueldo sea un número válido. Detalle: " + ex.Message, "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUPDATED_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Por favor seleccione un docente de la tabla para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTITULO.Text) || string.IsNullOrWhiteSpace(txtSALARIO.Text))
            {
                MessageBox.Show("Por favor complete los campos de Título y Sueldo.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Asignamos el ID que guardamos al hacer clic en la grilla
                docenteActual.Id = idSeleccionado;
                docenteActual.Titulo = txtTITULO.Text;
                docenteActual.Sueldo = double.Parse(txtSALARIO.Text.Replace(',', '.'), CultureInfo.InvariantCulture);

                if (db.ActualizarDocente(docenteActual) > 0)
                {
                    MessageBox.Show("Docente actualizado correctamente.", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.BuscarDocentes(dataDocente);
                    idSeleccionado = 0; // Reiniciamos la selección
                    txtTITULO.Text = "";
                    txtSALARIO.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor verifique que el sueldo sea un número válido. Detalle: " + ex.Message, "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDELETED_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Por favor seleccione un docente de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este docente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Eliminamos usando el ID de la persona seleccionada en la grilla
                if (db.EliminarDocente(idSeleccionado) > 0)
                {
                    MessageBox.Show("Docente eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.BuscarDocentes(dataDocente);
                    idSeleccionado = 0; // Reiniciamos la selección
                    txtTITULO.Text = "";
                    txtSALARIO.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
