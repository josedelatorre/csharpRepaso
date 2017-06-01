using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delaTorreLopezJose_EERR_ExamenFinal.Models
{
    class Profesor : Persona
    {
        public float Sueldo {
            get => Sueldo;
            set {
                if(value < 0)
                throw new Exception("Sueldo fuera de rango");

                Sueldo = value;
            }
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
