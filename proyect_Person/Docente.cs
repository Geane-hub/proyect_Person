using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyect_Person
{
    public class Docente : Persona
    {
        private string titulo;
        private double sueldo;

        public Docente() : base()
        {
            this.titulo = "";
            this.sueldo = 0.0;
        }

        public Docente(int id, string dni, string name, int yearBirth, string titulo, double sueldo)
            : base(id, dni, name, yearBirth)
        {
            this.titulo = titulo;
            this.sueldo = sueldo;
        }
        public string Titulo
        {
            get
            {
                if (titulo != null)
                {
                    return titulo;
                }
                else
                {
                    return "Vacio";
                }
            }
            set
            {
                if (value != null)
                {
                    titulo = value;
                }
                else
                {
                    titulo = null;
                }
            }
        }

        public double Sueldo
        {
            get
            {
                if (sueldo > 0)
                {
                    return sueldo;
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                if (value > 0)
                {
                    sueldo = value;
                }
                else
                {
                    sueldo = 0;
                }
            }
        }
        public double CalcularIESS()
        {
            // Porcentaje de aportación al IESS (ej. 9.45%)
            return Sueldo * 0.0945;
        }

        public double CalcularSueldoTotal()
        {
            return Sueldo - CalcularIESS();
        }
    }
}
