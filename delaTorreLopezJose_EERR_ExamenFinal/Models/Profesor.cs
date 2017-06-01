using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using delaTorreLopezJose_EERR_ExamenFinal.Interfaces;

namespace delaTorreLopezJose_EERR_ExamenFinal.Models
{
    class Profesor : Persona, IEvaluador
    {
        public float Sueldo {
            get => Sueldo;
            set {
                if(value < 0)
                throw new Exception("Sueldo fuera de rango");

                Sueldo = value;
            }
        }

        public Profesor(string Nombre, string Apellidos, int edad,
           float Sueldo) :
            base(Nombre, Apellidos, edad)
        {
            this.Sueldo = Sueldo;
        }

        public void Evaluar(Alumno a, float nota)
        {
            a.Nota = nota;
        }

        public void Regañar(string msg)
        {
            Console.WriteLine("REGAÑINA - " + msg);
        }

        public override void Saludar(string msg)
        {
            Console.WriteLine("Buenos días " + msg);
        }
    }
}
