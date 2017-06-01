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
        private float _Nota;

        public float Nota {
            get => _Nota;
            set {
                if (value < 0 || value > 10)
                    throw new Exception("Nota fuera de rango");
                _Nota = Nota;
            }
        }

        public Alumno(string Nombre, string Apellidos, int edad,
            string NMatricula) :
            base(Nombre, Apellidos, edad)
        {
            this.NMatricula = NMatricula;
            Nota = 0;
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
