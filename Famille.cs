using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETgesAMM
{
    class Famille
    {
        private string code;
        private string libelle;
        private int nbMediAmm;

        public Famille(string code, string libelle, int nbMediAmm)
        {
            this.code = code;
            this.libelle = libelle;
            this.nbMediAmm = nbMediAmm;
        }

        public string getCode() { return this.code; }
        public string getLibelle() { return this.libelle; }
        public int getNbMediAmm() { return this.nbMediAmm; }
    }



}

