using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delaTorreLopezJose_EERR_ExamenFinal.Models
{
    class Clase
    {
        public Profesor Profe { get; set; }
        public IList<Alumno> Alumnos { get; set; }

        public Clase(List<Alumno> a, Profesor p)
        {
            Alumnos = a;
            Profe = p;
        }

        public float CalcularMedia()
        {
            return Alumnos.Average(x => x.Nota);
        }

        public void EvaluarTodos() {
            if (Profe == null || Alumnos == null) {
                throw new Exception("Primero configura la clase!");
            }
            Console.WriteLine("-EVALUANDO-");
            foreach (var a in Alumnos) {
                var nota = LeerNota(a);
                Profe.Evaluar(a, nota);
            }
        }

        private float LeerNota(Alumno a) {
            Console.Write(String.Format("{0} nota ->", a));
            var notaStr = Console.ReadLine();
            var nota = 0f;
            float.TryParse(notaStr, out nota);
            return nota;
        }
    }
}
