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
            SqlCommand maRequete = new SqlCommand("prc_AfficherMedicament", Globale.cnx);
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
                string amm = SqlExec["MED_AMM"].ToString();

                Medicament leMedicament = new Medicament(depotMed, nomComMed, famCode, compMed, effetMed, contreIndicMed, amm);

                Globale.lesMedicaments.Add(depotMed, leMedicament);
            }
        }

        public static void lireLesFamilles()
        {
            Globale.lesFamilles.Clear();

            //Récupérer les familles de médicament présentes sur la base
            SqlCommand maRequete = new SqlCommand("prc_getFamille", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            while (SqlExec.Read())
            {
                string famCode = SqlExec["FAM_CODE"].ToString();
                string famLibelle = SqlExec["FAM_LIBELLE"].ToString();

                Famille laFamille = new Famille(famCode, famLibelle, 0);

                Globale.lesFamilles.Add(laFamille);
            }
        }

        public static void lireLesEtapesNormees()
        {
            Globale.lesEtapesNormees.Clear();

            //Récupérer les etapes normées dans la base
            SqlCommand maRequete = new SqlCommand("prc_afficherEtapeNormee", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sqlExec = maRequete.ExecuteReader();

            while (sqlExec.Read())
            {
                int ETP_ID = int.Parse(sqlExec["ETP_ID"].ToString());
                string ETP_NORME = sqlExec["ETP_NORME"].ToString();
                string ETP_LIBELLE = sqlExec["ETP_LIBELLE"].ToString();
                DateTime ETP_DATE_NORMEE = DateTime.Parse(sqlExec["ETP_DATE_NORMEE"].ToString());

                EtapeNormee laEtapeNormee = new EtapeNormee(ETP_ID, ETP_LIBELLE, ETP_NORME, ETP_DATE_NORMEE);

                Globale.lesEtapesNormees.Add(laEtapeNormee);
            }
            
        }

        public static Boolean insererMedoc(string LeDepotLegal, string LeNomCommercial, string LeFamCode, string LaCompo, string lesEffets, string LaContrindic)
        {
            SqlCommand maRequete = new SqlCommand("prc_insererMedicamaent", Globale.cnx);
            //Procédure stockée
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            //Paramètres
            SqlParameter DepotLegal = new SqlParameter("@DEPOTLEGAL", System.Data.SqlDbType.Char, 20);
            DepotLegal.Value = LeDepotLegal;
            SqlParameter NomCommercial = new SqlParameter("@NOMCOMMERCIAL", System.Data.SqlDbType.Char, 50);
            NomCommercial.Value = LeNomCommercial;
            SqlParameter FamCode = new SqlParameter("@FAMCODE", System.Data.SqlDbType.Char, 10);
            FamCode.Value = LeFamCode;
            SqlParameter Compo = new SqlParameter("@MEDCOMPOSITION", System.Data.SqlDbType.Text);
            Compo.Value = LaCompo;
            SqlParameter Effets = new SqlParameter("@EFFETS", System.Data.SqlDbType.Text);
            Effets.Value = lesEffets;
            SqlParameter Contrindic = new SqlParameter("@CONTREINDIC", System.Data.SqlDbType.Text);
            Contrindic.Value = LaContrindic;
            //Ajout des paramètres
            maRequete.Parameters.Add(DepotLegal);
            maRequete.Parameters.Add(NomCommercial);
            maRequete.Parameters.Add(FamCode);
            maRequete.Parameters.Add(Compo);
            maRequete.Parameters.Add(Effets);
            maRequete.Parameters.Add(Contrindic);

            //Execution
            try
            {
                maRequete.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Boolean majEtapeNormee(int leId, int leUser, string laAncienneNorme, string laNouvelleNorme, DateTime laAncienneDate, DateTime laNouvelleDate)
        {
            SqlCommand maRequete = new SqlCommand("prc_modifEtapeNormee", Globale.cnx);
            //Procédure stockée
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            //Paramètres
            SqlParameter id = new SqlParameter("@ID_ETAPE", System.Data.SqlDbType.Int);
            id.Value = leId;
            SqlParameter user = new SqlParameter("@ID_USER", System.Data.SqlDbType.Int);
            user.Value = leUser;
            SqlParameter ancienneNorme = new SqlParameter("@NORME", System.Data.SqlDbType.Char, 50);
            ancienneNorme.Value = laAncienneNorme;
            SqlParameter nouvelleNorme = new SqlParameter("@NEW_NORME", System.Data.SqlDbType.Char, 50) ;
            nouvelleNorme.Value = laNouvelleNorme;
            SqlParameter ancienneDate = new SqlParameter("@DATE_NORME", System.Data.SqlDbType.Date);
            ancienneDate.Value = laAncienneDate;
            SqlParameter nouvelleDate = new SqlParameter("@NEW_DATE_NORME", System.Data.SqlDbType.Date);
            nouvelleDate.Value = laNouvelleDate;

            maRequete.Parameters.Add(id);
            maRequete.Parameters.Add(user);
            maRequete.Parameters.Add(ancienneNorme);
            maRequete.Parameters.Add(nouvelleNorme);
            maRequete.Parameters.Add(ancienneDate);
            maRequete.Parameters.Add(nouvelleDate);

            //Execution

            maRequete.ExecuteNonQuery();
                return true;
        }

        public static Boolean ConnexionUtilisateurs(string identifiant, string mdp)
        {
            bool trouve = false;

            //Récupérer les familles de médicament présentes sur la base
            SqlCommand maRequete = new SqlCommand("prc_afficherUtilisateurs", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            while (SqlExec.Read() && !trouve)
            {
                if (identifiant == SqlExec["identifiant"].ToString() && mdp == SqlExec["mdp"].ToString())
                {
                    trouve = true;
                }
                Globale.idUser = int.Parse(SqlExec["idUser"].ToString());
            }
            return trouve;
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



            //boucle de lecture des medicaments et familles avec ajout dans la collection
            while (SqlExec.Read())
            {

                string depotMed = SqlExec["MED_DEPOTLEGAL"].ToString();
                string nomComMed = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string famCode = SqlExec["FAM_CODE"].ToString();
                string compMed = SqlExec["MED_COMPOSITION"].ToString();
                string effetMed = SqlExec["MED_EFFETS"].ToString();
                string contreIndicMed = SqlExec["MED_CONTREINDIC"].ToString();
                string amm = SqlExec["MED_AMM"].ToString();



                string famlibelle = SqlExec["FAM_LIBELLE"].ToString();
                int nbMediAmm = (int)SqlExec["FAM_NB_MEDI_AMM"];



                Famille laFamille = new Famille(famCode, famlibelle, nbMediAmm);
                Medicament leMedicament = new Medicament(depotMed, nomComMed, famCode, compMed, effetMed, contreIndicMed, amm);


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

                // boucle de lecture des differentes informations du medicament avec ajout dans leurs collections respectives
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

                    if (etapeNorme != "" && etapeDateNorme != null)
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
