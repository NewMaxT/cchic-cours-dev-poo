using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Capacité : Objet
    {
        private string _description = "\0";

        public Capacité(string nom, string description, string type) : base(nom, type) {
            this._description = description;
        }

        public string Description {
            get { return _description; }
        }
    }
}
