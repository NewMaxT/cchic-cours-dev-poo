using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Objet
    {
        private string _nom = "\0";
        private string _type = "\0";

        public Objet(string nom, string type) {
            _nom = nom;
            _type = type;
        }

        /// <summary>
        /// Getter/Setter of name
        /// </summary>
        /// <returns>string _nom</returns>
        public string getNom {
            get { return _nom; }
        }

        /// <summary>
        /// Getter/Setter 
        /// </summary>
        /// <returns>string _type</returns>
        public string getType {
            get { return _type; }
        }
    }
}
