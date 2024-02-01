using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Spécialisation
    {
        private List<Sortilege> _sortsPossibles = new List<Sortilege> { };
        private string _nom = "\0";

        public Spécialisation(string nom)
        {
            _nom = nom;
        }
        public Spécialisation(string nom, List<Sortilege> sorts)
        {
            _nom = nom;
            _sortsPossibles = sorts; 
        }

        public Sortilege AddSortilege {
            set { _sortsPossibles.Add(value); }
        }

        public List<Sortilege> SortsPossibles {
            get { return _sortsPossibles; }
            set { _sortsPossibles = value; }
        }

        public string Description { 
            get { return _nom; } 
        }
    }
}
