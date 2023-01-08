using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PROJETgesAMM
{
    class Modif { 
        private string Etape;
        private string User;
        private DateTime dateModif;
        private string ancienneNormee;
        private string nouvelleNorme;
        private DateTime ancienneDate;    
        private DateTime nouvelleDate;


        public Modif(string laEtape, string leUser, DateTime dateModif, string anNorme, string newNorme, DateTime anDate, DateTime newDate)
        {
            this.Etape = laEtape;
            this.User = leUser;
            this.dateModif = dateModif;
            this.ancienneNormee = anNorme;
            this.nouvelleNorme = newNorme;
            this.ancienneDate = anDate;
            this.nouvelleDate = newDate;
        }

        public string getEtape() { return this.Etape; }
        public string getUser() { return this.User; }
        public DateTime getDateModif() { return this.dateModif; }
        public string getAncienneNorme() { return this.ancienneNormee; }
        public string getNouvelleNorme() { return this.nouvelleNorme; }
        public DateTime getAncienneDate() { return this.ancienneDate; }
        public DateTime getNouvelleDate() { return this.nouvelleDate; }

    }
}
