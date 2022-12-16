using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PROJETgesAMM
{
    public static class bd
    {
        public static void lireLesMedicaments()
        {
            Globale.lesMedicaments.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_afficherMedicament", Globale.cnx);
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



                Medicament leMedicament = new Medicament(depotMed, nomComMed, famCode, compMed, effetMed, contreIndicMed, prixEchantillonMed);



                Globale.lesMedicaments.Add(depotMed, leMedicament);
            }
        }
        public static void lireLesFamilles()
        {
            Globale.lesFamilles.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_getFamille", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int code = (int)SqlExec["FAM_CODE"];
                string libelle = SqlExec["FAM_LIBELLE"].ToString();
                int nbMediAmm = (int)SqlExec["FAM_NBMEDIAMM"];




                Famille laFamille = new Famille(code, libelle, nbMediAmm);



                Globale.lesFamilles.Add(code.ToString(), laFamille);
            }
        }
        public static void etapesWorkflow()
        {



            Globale.lesMedicaments.Clear();
            Globale.lesEtapes.Clear();
            Globale.lesDecisions.Clear();




            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_afficherMedicament", Globale.cnx);
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





                Medicament leMedicament = new Medicament(depotMed, nomComMed, famCode, compMed, effetMed, contreIndicMed, prixEchantillonMed);





                Globale.lesMedicaments.Add(depotMed, leMedicament);



                Globale.lesMedicaments[depotMed].getLesEtapes().Clear();




                //gestion des factures du workflow
                SqlCommand maRequeteWorkflow = new SqlCommand("prc_afficherWorkflowEtapeMedicament", Globale.cnx);
                maRequeteWorkflow.CommandType = System.Data.CommandType.StoredProcedure;



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
                    string depotLegal = SqlExecWorkflow["ETP_LIBELLE"].ToString();



                    Etape uneEtape;



                    if (etapeNorme != "" && etapeDateNorme != null)
                    {
                        uneEtape = new EtapeNormee(numEtape, libelleEtape, etapeNorme, etapeDateNorme);
                    }
                    else
                    {
                        uneEtape = new Etape(numEtape, libelleEtape);
                    }




                    Workflow leWorkflow = new Workflow(dateDecison, numEtape, idDecision, depotLegal);
                    Decision laDecision = new Decision(idDecision, libelleDecision);



                    Globale.lesMedicaments[depotMed].getLesEtapes().Add(leWorkflow);
                    Globale.lesEtapes.Add(uneEtape);
                    Globale.lesDecisions.Add(laDecision);



                }





            }



    
 



        }
    }
}
