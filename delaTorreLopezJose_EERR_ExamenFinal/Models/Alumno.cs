using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delaTorreLopezJose_EERR_ExamenFinal.Models
{
    class Alumno : Persona
    {
        public string NMatricula { get; set; }
        public float Nota {
            get => Nota;
            set {
                if (Nota < 0 || Nota > 10)
                    throw new Exception("Nota fuera de rango");
            }
        }

        public Alumno(string Nombre, string Apellidos, int edad,
            string NMatricula) :
            base(Nombre, Apellidos, edad)
        {
            this.NMatricula = NMatricula;
            this.Nota = 0;
        }

        public Alumno(string Nombre, string Apellidos, int edad, 
            string NMatricula, float Nota) :
            base(Nombre, Apellidos, edad)
        {
            this.NMatricula = NMatricula;
            this.Nota = Nota;
        }

        public void Quejarse(string msg) {
            Console.WriteLine("QUEJA - " + msg);
        }

        public override void Saludar(string msg)
        {
            Console.WriteLine("Ehhhh " + msg);
        }
    }
}
