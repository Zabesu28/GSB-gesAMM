using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Numerics;
using System.Net;
using System.Text.RegularExpressions;

namespace PROJETgesAMM
{
    public static class bd
    {
        public static void lireLesMedicaments()
        {
            Globale.lesMedicaments.Clear();
            

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_listeTousMedicaments", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string depotMed = SqlExec["MED_DEPOTLEGAL"].ToString();
                string nomComMed = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string famCode = SqlExec["FAM_CODE"].ToString();
                string compMed = SqlExec["MED_COMPOSITION"].ToString();
                string effetMed = SqlExec["MED_EFFETS"].ToString();
                string contreIndicMed = SqlExec["MED_CONTREINDIC"].ToString();
                string prixEchantillonMed = SqlExec["MED_PRIXECHANTILLON"].ToString();
                string amm = SqlExec["MED_AMM"].ToString();



                Medicament leMedicament = new Medicament(depotMed, nomComMed, famCode, compMed, effetMed, contreIndicMed, prixEchantillonMed, amm);



                Globale.lesMedicaments.Add(depotMed, leMedicament);
            }
        }


        public static void lireLesMedicamentsEnCours()
        {
            Globale.lesMedicaments.Clear();
            Globale.lesFamilles.Clear();


            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_listeTousMedicamentsEnCours", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                
                string depotMed = SqlExec["MED_DEPOTLEGAL"].ToString();
                string nomComMed = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string famCode = SqlExec["FAM_CODE"].ToString();
                string compMed = SqlExec["MED_COMPOSITION"].ToString();
                string effetMed = SqlExec["MED_EFFETS"].ToString();
                string contreIndicMed = SqlExec["MED_CONTREINDIC"].ToString();
                string prixEchantillonMed = SqlExec["MED_PRIXECHANTILLON"].ToString();
                string amm = SqlExec["MED_AMM"].ToString();

                string famlibelle = SqlExec["FAM_LIBELLE"].ToString();
                int nbMediAmm = (int)SqlExec["FAM_NB_MEDI_AMM"];

                Famille laFamille = new Famille(famCode, famlibelle, nbMediAmm);
                Medicament leMedicament = new Medicament(depotMed, nomComMed, famCode, compMed, effetMed, contreIndicMed, prixEchantillonMed, amm);
                


                
                Globale.lesFamilles.Add(laFamille);
                Globale.lesMedicaments.Add(depotMed, leMedicament);
            }
        }


        public static void etapesWorkflow(string depotLegal)
        {

            
            Globale.lesEtapes.Clear();
            Globale.lesDecisions.Clear();

            SqlCommand maRequeteWorkflow = new SqlCommand("prc_afficherWorkflowEtapeMedicament", Globale.cnx);
            maRequeteWorkflow.CommandType = System.Data.CommandType.StoredProcedure;

            // Ajouter les parameters à la procédure stockée
            SqlParameter paramDepotLegal = new SqlParameter("@depotlegal", System.Data.SqlDbType.Char, 30);
            paramDepotLegal.Value = depotLegal;
            maRequeteWorkflow.Parameters.Add(paramDepotLegal);

            // exécuter la procedure stockée
 

            SqlDataReader SqlExecWorkflow = maRequeteWorkflow.ExecuteReader();

                while (SqlExecWorkflow.Read())
                {

                    int numEtape = (int)SqlExecWorkflow["ETP_NUM"];
                    string libelleEtape = SqlExecWorkflow["ETP_LIBELLE"].ToString();
                    DateTime dateDecison = DateTime.Parse(SqlExecWorkflow["DateDecision"].ToString());
                    int idDecision = (int)SqlExecWorkflow["DCS_ID"];
                    string libelleDecision = SqlExecWorkflow["DCS_LIBELLE"].ToString();
                    string etapeNorme = SqlExecWorkflow["ETP_NORME"].ToString();
                    DateTime etapeDateNorme = DateTime.Parse(SqlExecWorkflow["ETP_DATE_NORMEE"].ToString());
                    string depotLegalMed = SqlExecWorkflow["DepotLegal"].ToString();

                    Etape uneEtape;

                    if(etapeNorme != "" && etapeDateNorme != null)
                    {
                        uneEtape = new EtapeNormee(numEtape, libelleEtape, etapeNorme, etapeDateNorme);
                    }
                    else
                    {
                        uneEtape = new Etape(numEtape, libelleEtape);
                    }


                    Workflow leWorkflow = new Workflow(dateDecison, numEtape, idDecision, depotLegalMed);
                    Decision laDecision = new Decision(idDecision, libelleDecision);

                    Globale.lesMedicaments[depotLegal].getLesEtapes().Add(leWorkflow);
                    Globale.lesEtapes.Add(uneEtape);
                    Globale.lesDecisions.Add(laDecision);   

                }



            }

            

        }

    
}
