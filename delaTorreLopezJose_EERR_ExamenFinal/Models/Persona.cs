using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using delaTorreLopezJose_EERR_ExamenFinal.Interfaces;

namespace delaTorreLopezJose_EERR_ExamenFinal.Models
{
    abstract class Persona : ISaludable
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        private int edad;

        public Persona(string Nombre, string Apellidos, int edad)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.edad = edad;
        }

        //Getters y setters como en Java
        public int getEdad() {
            return edad;
        }

        public void setEdad(int edad){
            if (edad < 0) {
                throw new Exception("La edad no puede ser menor de 0");
            }
            this.edad = edad;
        }

        public abstract void Saludar(string msg);

        public void Andar() {
            Console.WriteLine("Estoy andando");
        }

        public override string ToString()
        {
            return String.Format("{0} {1} ", Nombre, Apellidos);
        }
    }
}
