
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrera
{
    class Corredores
    {
        public int _pos;
        public string animal;
        private int _num;
        private string _name;
        private Random gen = new Random();
        
        public Corredores(string name)
        {
            _name = name;
            _pos = 0;
        }
        /// <summary>
        /// Retorna la posición actual del jugador
        /// </summary>
        public int Posicion
        {
            //set { _pos = value; } //
            get { return _pos; }
        }
        /// <summary>
        /// Retorna el nombre del jugador
        /// </summary>
        public string Name
        {
            get { return _name; }
        }


        public override string ToString()
        {
            return $"{animal} esta en: " + _pos.ToString();
        }
    }

}

