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
        private string amm;
        private int derniereEtape;
        private List<Workflow> lesEtapes;



        public Medicament(string depotLegal, string nomCommercial, string famCode, string composition, string effets, string contreIndications, string amm)
        {
            this.depotLegal = depotLegal;
            this.nomCommercial = nomCommercial;
            this.famCode = famCode;
            this.composition = composition;
            this.effets = effets;
            this.contreIndications = contreIndications;
            this.amm = amm;
            this.derniereEtape = 0;
            this.lesEtapes = new List<Workflow>();
        }



        public string getDepotLegal() { return this.depotLegal; }
        public string getNomCommercial() { return this.nomCommercial; }
        public string getFamCode() { return this.famCode; }
        public string getComposition() { return this.composition; }
        public string getEffets() { return this.effets; }
        public string getContreIndications() { return this.contreIndications; }
        public string getAmm() { return this.amm; }
        public int getDerniereEtape() 
        {
            
            return lesEtapes.Count;
        }
        public List<Workflow> getLesEtapes() { return this.lesEtapes; }

        public void setWorkflow(List<Workflow> PLEASE)
        {
        }



    }
}