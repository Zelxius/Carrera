using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrera
{
    class Tortuga : Corredores
    {
        private Random Random = new Random();
        /// <summary>
        /// Constructor de la clase tortuga
        /// Asigna la especie de animal
        /// </summary>
        /// <param name="name">Asigna el nombre del jugador</param>
        public Tortuga(string name) : base(name)
        {
            base.animal = "Tortuga";
        }

        public void Mover()
        {
            int perCent = Random.Next(0, 100);

            if (perCent <= 40) {
                Console.WriteLine($"+3\tpasos");
                base._pos += 3;
            } else if (perCent <= 70) {
                Console.WriteLine($"+6\tpasos");
                base._pos += 6;
            } else if (perCent <= 90) {
                Console.WriteLine($"-5\tresbalón");
                base._pos -= 5;
            } else if (perCent <= 100) {
                Console.WriteLine($"-9\tcaida");
                base._pos -= 9;
            }
        }
    }
}
