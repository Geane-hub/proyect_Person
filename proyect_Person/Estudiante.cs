using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyect_Person
{
    public class Estudiante : Persona
    {
        private double nota1;
        private double nota2;

        public Estudiante() : base()
        {
            this.nota1 = 0.0;
            this.nota2 = 0.0;
        }

        public Estudiante(int id, string dni, string name, int yearBirth, double nota1, double nota2)
            : base(id, dni, name, yearBirth)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public double Nota1
        {
            get
            {
                if (nota1 >= 0)
                {
                    return nota1;
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                if (value >= 0)
                {
                    nota1 = value;
                }
                else
                {
                    nota1 = 0;
                }
            }
        }
        public double Nota2
        {
            get
            {
                if (nota2 >= 0)
                {
                    return nota2;
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                if (value >= 0)
                {
                    nota2 = value;
                }
                else
                {
                    nota2 = 0;
                }
            }
        }

        public double Suma(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Promedio(double n1, double n2)
        {
            return Suma(n1, n2) / 2.0;
        }
    }
}
