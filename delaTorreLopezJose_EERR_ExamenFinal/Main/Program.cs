using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using delaTorreLopezJose_EERR_ExamenFinal.Models;

namespace delaTorreLopezJose_EERR_ExamenFinal
{
    class Program
    {
        static void Main(string[] args)
         {
            Console.WriteLine("Hola Mundo!");
            var miClase = new Clase();
            miClase.Alumnos = CargarAlumnos();

            try
            {
                miClase.EvaluarTodos();
            } catch (Exception e) {
                Console.WriteLine(e);
            }

            //Fin de programa
            Console.ReadLine();
        }

        private static IList<Alumno> CargarAlumnos()
        {
            var lista = new List<Alumno>();

            lista.Add(new Alumno("Yusep","Guardiola", 32, "ER20983"));
            lista.Add(new Alumno("Salvatore", "Mojonen", 31, "ER20984"));
            lista.Add(new Alumno("Utrero", "Rusep", 32, "ER20985"));
            lista.Add(new Alumno("Maxy", "Iglesias", 23, "ER20973"));
            lista.Add(new Alumno("Yusep", "Ratata", 33, "ER20345"));
            lista.Add(new Alumno("Isma", "El", 43, "ER20789"));

            return lista;
        }
    }
}
