using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Personnage
    {
        private int _vie = 0;
        private int _force = 0;
        private int _mana = 0;
        private int _agilité = 0;
        private int _or = 0;

        private List<Objet> _inventaire;
        private List<Capacité> _capacités;
        private List<Sortilege> _sortileges;
        private Spécialisation _sp;

        public Personnage(int vie, int force, int mana, int agilité, int or, List<Objet> inventaire, List<Capacité> capacités,Spécialisation spécialisation)
        {
            _vie = vie;
            _force = force;
            _mana = mana;
            _agilité = agilité;
            _or = or;

            _inventaire = inventaire;
            _capacités = capacités;
            _sp = spécialisation;
            _sortileges = spécialisation.SortsPossibles;
        }

        public int Vie { get => _vie; set => _vie = value; }
        public int Force { get => _force; set => _force = value; }
        public int Mana { get => _mana; set => _mana = value; }
        public int Agilité { get => _agilité; set => _agilité = value; }
        public int Or { get => _or; set => _or = value; }
        internal List<Objet>? Inventaire { get => _inventaire; set => _inventaire = value; }
        internal List<Capacité>? Capacités { get => _capacités; set => _capacités = value; }
        internal List<Sortilege>? Sortileges { get => _sortileges; set => _sortileges = value; }
        internal Spécialisation? Sp { get => _sp; set => _sp = value; }
    }
}
