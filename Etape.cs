using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETgesAMM
{
    class Etape
    {
        private int num;
        private string libelle;

        public Etape(int num, string libelle)
        {
            this.num = num;
            this.libelle = libelle;
        }

        public int getNum() { return this.num; }
        public string getLibelle() { return this.libelle; }
    }
}
