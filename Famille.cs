using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETgesAMM
{
    class Famille
    {
        private int code;
        private string libelle;
        private int nbMediAmm;

        public Famille(int code, string libelle, int nbMediAmm)
        {
            this.code = code;
            this.libelle = libelle;
            this.nbMediAmm = nbMediAmm;
        }

        public int getCode() { return this.code; }
        public string getLibelle() { return this.libelle; }
        public int getNbMediAmm() { return this.nbMediAmm; }
    }



}

