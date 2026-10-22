using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyect_Person
{
    public class db_igmr
    {
        public MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection(
                "server = 127.0.0.1; " +
                "database= db_igmr; " + 
                "Uid= root;" +
                "pwd=;");
            try
            {
                conectar.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la DB: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conectar;
        }

        // Método para registrar primero en la tabla 'person' y obtener su ID generado
        public int AgregarPersona(Persona p)
        {
            try
            {
                int idGenerado = 0;
                string query = string.Format(CultureInfo.InvariantCulture,
                    "INSERT INTO person (dni, name, yearBirth) VALUES ('{0}', '{1}', {2}); SELECT LAST_INSERT_ID();",
                    p.Dni, p.Name, p.YearBirth);

                using (MySqlConnection conn = this.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand(query, conn);
                    idGenerado = Convert.ToInt32(comando.ExecuteScalar());
                }
                return idGenerado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar persona en la base de datos: " + ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public int ActualizarPersona(Persona p)
        {
            try
            {
                int retorno = 0;
                using (MySqlConnection conexion = this.ObtenerConexion())
                {
                    string query = string.Format(CultureInfo.InvariantCulture,
                        "UPDATE person SET dni = '{0}', name = '{1}', yearBirth = {2} WHERE id = {3}",
                        p.Dni, p.Name, p.YearBirth, p.Id);

                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    retorno = comando.ExecuteNonQuery();
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar persona: " + ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public int EliminarPersona(int idPersona)
        {
            try
            {
                int retorno = 0;
                using (MySqlConnection conexion = this.ObtenerConexion())
                {
                    string query = string.Format("DELETE FROM teacher WHERE id = {0}; DELETE FROM student WHERE id = {0}; DELETE FROM person WHERE id = {0};", idPersona);
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    retorno = comando.ExecuteNonQuery();
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar persona: " + ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        // Método para agregar Docente
        public int AgregarDocente(Docente d)
        {
            int idPersona = AgregarPersona(d);
            if (idPersona <= 0) return -1;

            try
            {
                int retorno = 0;
                using (MySqlConnection conn = this.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand(
                        string.Format(CultureInfo.InvariantCulture,
                        "INSERT INTO teacher (id, title, sueldo) VALUES ({0}, '{1}', {2})",
                        idPersona, d.Titulo, d.Sueldo),
                        conn);
                    retorno = comando.ExecuteNonQuery();
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar docente: " + ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public int ActualizarDocente(Docente d)
        {
            try
            {
                int retorno = 0;
                using (MySqlConnection conexion = this.ObtenerConexion())
                {
                    string query = string.Format(CultureInfo.InvariantCulture,
                        "UPDATE teacher SET title = '{0}', sueldo = {1} WHERE id = {2}",
                        d.Titulo, d.Sueldo, d.Id);

                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    retorno = comando.ExecuteNonQuery();
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar docente: " + ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public int EliminarDocente(int idPersona)
        {
            try
            {
                int retorno = 0;
                using (MySqlConnection conexion = this.ObtenerConexion())
                {
                    string query = string.Format("DELETE FROM teacher WHERE id = {0}; DELETE FROM person WHERE id = {0};", idPersona);
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    retorno = comando.ExecuteNonQuery();
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar docente: " + ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        // Método para agregar Estudiante
        public int AgregarEstudiante(Estudiante e)
        {
            int idPersona = AgregarPersona(e);
            if (idPersona <= 0) return -1;

            try
            {
                int retorno = 0;
                using (MySqlConnection conn = this.ObtenerConexion())
                {
                    string query = string.Format(CultureInfo.InvariantCulture,
                        "INSERT INTO student (id, nota1, nota2) VALUES ({0}, {1}, {2})",
                        idPersona, e.Nota1, e.Nota2);

                    MySqlCommand comando = new MySqlCommand(query, conn);
                    retorno = comando.ExecuteNonQuery();
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar estudiante: " + ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public int ActualizarEstudiante(Estudiante e)
        {
            try
            {
                int retorno = 0;
                using (MySqlConnection conexion = this.ObtenerConexion())
                {
                    string query = string.Format(CultureInfo.InvariantCulture,
                        "UPDATE student SET nota1 = {0}, nota2 = {1} WHERE id = {2}",
                        e.Nota1, e.Nota2, e.Id);

                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    retorno = comando.ExecuteNonQuery();
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar estudiante: " + ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public int EliminarEstudiante(int idPersona)
        {
            try
            {
                int retorno = 0;
                using (MySqlConnection conexion = this.ObtenerConexion())
                {
                    string query = string.Format("DELETE FROM student WHERE id = {0}; DELETE FROM person WHERE id = {0};", idPersona);
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    retorno = comando.ExecuteNonQuery();
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar estudiante: " + ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        // Buscar/Listar Docentes uniendo las tablas
        public void BuscarDocentes(DataGridView grilla)
        {
            if (grilla.Rows.Count >= 0)
            {
                grilla.Rows.Clear();
            }
            try
            {
                using (MySqlConnection conexion = this.ObtenerConexion())
                {
                    MySqlCommand _comando = new MySqlCommand(
                        "SELECT p.id, p.name, p.dni, t.title, t.sueldo FROM person p JOIN teacher t ON p.id = t.id",
                        conexion);
                    using (MySqlDataReader _reader = _comando.ExecuteReader())
                    {
                        while (_reader.Read())
                        {
                            Docente d = new Docente();
                            d.Id = _reader.GetInt32(0);
                            d.Name = _reader.IsDBNull(1) ? "" : _reader.GetString(1);
                            d.Dni = _reader.IsDBNull(2) ? "" : _reader.GetString(2);
                            d.Titulo = _reader.IsDBNull(3) ? "" : _reader.GetString(3);
                            d.Sueldo = _reader.IsDBNull(4) ? 0.0 : Convert.ToDouble(_reader.GetValue(4));

                            string[] rows = new string[]
                            {
                                Convert.ToString(d.Id),
                                d.Name,
                                d.Dni,
                                d.Titulo,
                                Convert.ToString(d.Sueldo, CultureInfo.InvariantCulture),
                                Convert.ToString(d.CalcularIESS(), CultureInfo.InvariantCulture),
                                Convert.ToString(d.CalcularSueldoTotal(), CultureInfo.InvariantCulture)
                            };

                            grilla.Rows.Add(rows);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los datos de docentes: " + ex.Message);
            }
        }

        // Buscar/Listar Estudiantes uniendo las tablas
        public void BuscarEstudiantes(DataGridView grilla)
        {
            if (grilla.Rows.Count >= 0)
            {
                grilla.Rows.Clear();
            }
            try
            {
                using (MySqlConnection conexion = this.ObtenerConexion())
                {
                    MySqlCommand _comando = new MySqlCommand(
                        "SELECT p.id, p.name, p.dni, s.nota1, s.nota2 FROM person p JOIN student s ON p.id = s.id",
                        conexion);
                    using (MySqlDataReader _reader = _comando.ExecuteReader())
                    {
                        while (_reader.Read())
                        {
                            Estudiante est = new Estudiante();
                            est.Id = _reader.GetInt32(0);
                            est.Name = _reader.IsDBNull(1) ? "" : _reader.GetString(1);
                            est.Dni = _reader.IsDBNull(2) ? "" : _reader.GetString(2);
                            est.Nota1 = _reader.IsDBNull(3) ? 0.0 : Convert.ToDouble(_reader.GetValue(3));
                            est.Nota2 = _reader.IsDBNull(4) ? 0.0 : Convert.ToDouble(_reader.GetValue(4));

                            string[] rows = new string[]
                            {
                                Convert.ToString(est.Id),
                                est.Name,
                                est.Dni,
                                Convert.ToString(est.Nota1, CultureInfo.InvariantCulture),
                                Convert.ToString(est.Nota2, CultureInfo.InvariantCulture),
                                Convert.ToString(est.Suma(est.Nota1, est.Nota2), CultureInfo.InvariantCulture),
                                Convert.ToString(est.Promedio(est.Nota1, est.Nota2), CultureInfo.InvariantCulture)
                            };

                            grilla.Rows.Add(rows);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los datos de estudiantes: " + ex.Message);
            }
        }

        // Buscar/Listar todas las Personas para la grilla de Form1
        public void BuscarPersonas(DataGridView grilla)
        {
            if (grilla.Rows.Count >= 0)
            {
                grilla.Rows.Clear();
            }
            try
            {
                using (MySqlConnection conexion = this.ObtenerConexion())
                {
                    string query = @"SELECT p.id, p.dni, p.name, p.yearBirth, 
                                     CASE 
                                         WHEN t.id IS NOT NULL THEN 'Docente' 
                                         WHEN s.id IS NOT NULL THEN 'Estudiante' 
                                         ELSE 'Persona' 
                                     END AS tipo 
                                     FROM person p 
                                     LEFT JOIN teacher t ON p.id = t.id 
                                     LEFT JOIN student s ON p.id = s.id";

                    MySqlCommand _comando = new MySqlCommand(query, conexion);
                    using (MySqlDataReader _reader = _comando.ExecuteReader())
                    {
                        while (_reader.Read())
                        {
                            int id = _reader.GetInt32(0);
                            string dni = _reader.IsDBNull(1) ? "" : _reader.GetString(1);
                            string name = _reader.IsDBNull(2) ? "" : _reader.GetString(2);
                            int yearBirth = _reader.IsDBNull(3) ? 0 : _reader.GetInt32(3);
                            string tipo = _reader.IsDBNull(4) ? "Persona" : _reader.GetString(4);

                            Persona p = new Persona(id, dni, name, yearBirth);

                            string[] rows = new string[]
                            {
                                Convert.ToString(p.Id),
                                p.Dni,
                                p.Name,
                                Convert.ToString(p.YearBirth),
                                tipo,
                                Convert.ToString(p.CalcularEdad())
                            };

                            grilla.Rows.Add(rows);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los datos de personas: " + ex.Message);
            }
        }
    }
}
