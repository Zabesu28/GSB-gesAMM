using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETgesAMM
{
    class Workflow
    {
        private DateTime dateDecision;
        private int numEtape;
        private int idDecision;
        private string depotLegal;

        public Workflow(DateTime dateDecision, int numEtape, int idDecision, string depotLegal)
        {
            this.dateDecision = dateDecision;
            this.numEtape = numEtape;
            this.idDecision = idDecision;
            this.depotLegal = depotLegal;
        }

        public DateTime getDateDecision() { return this.dateDecision; }
        public int getNumEtape() { return this.numEtape; }
        public int getIdDecision() { return this.idDecision; }

    }
}
