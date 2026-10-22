using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyect_Person
{
    public class Persona
    {
        private int id;
        private string dni;
        private string name;
        private int yearBirth;

        public Persona()
        {
            this.id = 0;
            this.dni = "";
            this.name = "";
            this.yearBirth = 0;
        }

        public Persona(int id, string dni, string name, int yearBirth)
        {
            this.id = id;
            this.dni = dni;
            this.name = name;
            this.yearBirth = yearBirth;
        }

        public int Id
        {
            get
            {
                if (id > 0)
                {
                    return id;
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
                    id = value;
                }
                else
                {
                    id = 0;
                }
            }
        }
        public string Dni
        {
            get
            {
                if (dni != null)
                {
                    return dni;
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
                    dni = value;
                }
                else
                {
                    dni = null;
                }
            }
        }
        public string Name
        {
            get
            {
                if (name != null)
                {
                    return name;
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
                    name = value;
                }
                else
                {
                    name = null;
                }
            }
        }

        public int YearBirth
        {
            get
            {
                if (yearBirth > 0)
                {
                    return yearBirth;
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
                    yearBirth = value;
                }
                else
                {
                    yearBirth = 0;
                }
            }
        }
        public int CalcularEdad()
        {
            int anioActual = DateTime.Now.Year;
            return ( anioActual - YearBirth);
        }
    }
}
