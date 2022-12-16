using System;
using System.Collections.Generic;
using System.Text;



namespace PROJETgesAMM
{
    class Medicament
    {
        private string depotLegal;
        private string nomCommercial;
        private string famCode;
        private string composition;
        private string effets;
        private string contreIndications;
        private string prixEchantillon;
        private string amm;
        private int derniereEtape;
        private List<Workflow> lesEtapes;



        public Medicament(string depotLegal, string nomCommercial, string famCode, string composition, string effets, string contreIndications, string prixEchantillon)
        {
            this.depotLegal = depotLegal;
            this.nomCommercial = nomCommercial;
            this.famCode = famCode;
            this.composition = composition;
            this.effets = effets;
            this.contreIndications = contreIndications;
            this.prixEchantillon = prixEchantillon;
            this.amm = "";
            this.derniereEtape = 0;
            this.lesEtapes = new List<Workflow>();
        }



        public string getDepotLegal() { return this.depotLegal; }
        public string getNomCommercial() { return this.nomCommercial; }
        public string getFamCode() { return this.famCode; }
        public string getComposition() { return this.composition; }
        public string getEffets() { return this.effets; }
        public string getContreIndications() { return this.contreIndications; }
        public string getPrixEchantillon() { return this.prixEchantillon; }
        public string getAmm() { return this.amm; }
        public int getDerniereEtape() { return this.derniereEtape; }
        public List<Workflow> getLesEtapes() { return this.lesEtapes; }



    }
}