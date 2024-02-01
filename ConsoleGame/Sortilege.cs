using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Sortilege
    {
        private int _coutMana;
        private string _nom = "\0";

        public Sortilege(string nom, int manaCost)
        {
            _nom = nom;
            _coutMana = manaCost;
        }

        public int ManaCost { 
            get { return _coutMana; }
        }

        public string Name {
            get { return _nom; }
        }
    }
}
