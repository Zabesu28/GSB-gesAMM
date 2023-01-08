using System;
using System.Collections.Generic;
using System.Text;

namespace  PROJETgesAMM

{
    class Decision
    {
        private int id;
        private string libelle;


        public Decision(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;

        }

        public int getId() { return this.id; }
        public string getLibelle() { return this.libelle; }
    }
}
