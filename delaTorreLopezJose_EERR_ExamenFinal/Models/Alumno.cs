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
        private int Nota {
            get { return Nota }
            set {
                if (Nota < 0 || Nota > 10)
                    throw new Exception("Nota fuera de rango");
            }

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
