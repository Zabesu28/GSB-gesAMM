using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETgesAMM
{
    class EtapeNormee : Etape
    {
        private string norme;
        private DateTime dateNorme;

        public EtapeNormee(int num, string libelle, string norme, DateTime dateNormee) : base(num, libelle)
        {
            this.norme = norme;
            this.dateNorme = dateNormee;
        }

        public string getNorme() { return this.norme; }
        public DateTime getDateNorme() { return this.dateNorme; }
    }
}
