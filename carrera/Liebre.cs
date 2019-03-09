using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrera
{
    class Liebre : Corredores
    {
        private Random Random = new Random();
        /// <summary>
        /// Constructor de la clase Liebre
        /// </summary>
        /// <param name="name">Permite al jugador asignar un nombre</param>
        public Liebre(string name) : base(name)
        {
            base.animal = "Liebre";
        }
        /// <summary>
        /// Método que calcula los movimientos con base al porcentaje de probabilidad
        /// </summary>
        public void Mover()
        {
            int perCent = Random.Next(0, 100);

            if (perCent <= 20)
            {
                Console.WriteLine($"+0\t duerme");
                base._pos += 0;
            }
            else if (perCent <= 45)
            {
                Console.WriteLine($"+12\t salta");
                base._pos += 12;
            }
            else if (perCent <= 65)
            {
                Console.WriteLine($"+5\t corre");
                base._pos += 5;
            }
            else if (perCent <= 80)
            {
                Console.WriteLine($"-4\t resbala");
                base._pos -= 4;
            }
            else if (perCent <= 100)
            {
                Console.WriteLine($"-8\t caida");
                base._pos -= 8;
            }
        }
    }
}
