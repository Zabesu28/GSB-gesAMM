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
<<<<<<< HEAD
            SqlCommand maRequete = new SqlCommand("prc_AfficherMedicament", Globale.cnx);
=======
            SqlCommand maRequete = new SqlCommand("getMedicaments", Globale.cnx);
>>>>>>> feature_clement
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string depotMed = SqlExec["MED_DEPOTLEGAL"].ToString();
                string nomComMed = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string famCode = SqlExec["MED_FAM_CODE"].ToString();
                string compMed = SqlExec["MED_COMPOSITION"].ToString();
                string effetMed = SqlExec["MED_EFFETS"].ToString();
                string contreIndicMed = SqlExec["MED_CONTREINDIC"].ToString();
                string amm = SqlExec["MED_AMM"].ToString();

                Medicament leMedicament = new Medicament(depotMed, nomComMed, famCode, compMed, effetMed, contreIndicMed, amm);

                Globale.lesMedicaments.Add(depotMed, leMedicament);
            }
        }

<<<<<<< HEAD
        public static void lireLesFamilles()
        {
            Globale.lesFamilles.Clear();
=======
                Medicament leMedicament = new Medicament(depotMed, nomComMed, famCode, compMed, effetMed, contreIndicMed, amm);
>>>>>>> feature_clement

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

<<<<<<< HEAD
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

=======
>>>>>>> feature_clement
        public static void lireLesMedicamentsEnCours()
        {
            Globale.lesMedicaments.Clear();
            Globale.lesFamilles.Clear();




<<<<<<< HEAD
=======


>>>>>>> feature_clement
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_listeTousMedicamentsEnCours", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;



<<<<<<< HEAD
=======


>>>>>>> feature_clement
            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();



<<<<<<< HEAD
=======


>>>>>>> feature_clement
            //boucle de lecture des medicaments et familles avec ajout dans la collection
            while (SqlExec.Read())
            {

<<<<<<< HEAD
=======


>>>>>>> feature_clement
                string depotMed = SqlExec["MED_DEPOTLEGAL"].ToString();
                string nomComMed = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string famCode = SqlExec["FAM_CODE"].ToString();
                string compMed = SqlExec["MED_COMPOSITION"].ToString();
                string effetMed = SqlExec["MED_EFFETS"].ToString();
                string contreIndicMed = SqlExec["MED_CONTREINDIC"].ToString();
                string amm = SqlExec["MED_AMM"].ToString();



<<<<<<< HEAD
=======


>>>>>>> feature_clement
                string famlibelle = SqlExec["FAM_LIBELLE"].ToString();
                int nbMediAmm = (int)SqlExec["FAM_NB_MEDI_AMM"];



<<<<<<< HEAD
                Famille laFamille = new Famille(famCode, famlibelle, nbMediAmm);
                Medicament leMedicament = new Medicament(depotMed, nomComMed, famCode, compMed, effetMed, contreIndicMed, amm);
=======


                Famille laFamille = new Famille(famCode, famlibelle, nbMediAmm);
                Medicament leMedicament = new Medicament(depotMed, nomComMed, famCode, compMed, effetMed, contreIndicMed, amm);


>>>>>>> feature_clement


                Globale.lesFamilles.Add(laFamille);
                Globale.lesMedicaments.Add(depotMed, leMedicament);
            }
        }
            public static void etapesWorkflow(string depotLegal)
            {

<<<<<<< HEAD
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
=======
        public static void lireLesEtapes()
        {
            Globale.lesEtapes.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("getEtape", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int etpNum = Convert.ToInt32(SqlExec["ETP_NUM"]);
                string etpName = SqlExec["ETP_LIBELLE"].ToString();
         



                
                    Etape etape = new Etape(etpNum, etpName);
                    Globale.lesEtapes.Add(etape);
                




                
            }
        }

     


        public static Boolean inseretDecisionEtape(string LeMed, int LEtpNum, DateTime LaDateDecision, int LaDecision)
        {
            SqlCommand maRequete = new SqlCommand("prc_decisionEtape", Globale.cnx);
            //Procédure stockée
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            //Paramètres
            SqlParameter med = new SqlParameter("@med", System.Data.SqlDbType.Char, 500);
            med.Value = LeMed;
            SqlParameter etpNum = new SqlParameter("@etpNum", System.Data.SqlDbType.Int);
            etpNum.Value = LEtpNum;
            SqlParameter dateDecision = new SqlParameter("@dateDecision", System.Data.SqlDbType.Date);
            dateDecision.Value = LaDateDecision;
            SqlParameter Decision = new SqlParameter("@Decision", System.Data.SqlDbType.Int);
            Decision.Value = LaDecision;

            //Ajout des paramètres
            maRequete.Parameters.Add(med);
            maRequete.Parameters.Add(etpNum);
            maRequete.Parameters.Add(dateDecision);
            maRequete.Parameters.Add(Decision);

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

        public static void lireLesFamilles()
        {
            Globale.lesFamilles.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("getFamille", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string code = SqlExec["FAM_CODE"].ToString();
                string libelle = SqlExec["FAM_LIBELLE"].ToString();
                int nbMediAmm = (int)SqlExec["FAM_NB_MEDI_AMM"];




                Famille laFamille = new Famille(code, libelle, nbMediAmm);



                Globale.lesFamilles.Add( laFamille);
            }
        }

        public static void etapesWorkflowNormees(string depotlegal)
        {



            Globale.lesMedicaments.Clear();
            
            Globale.lesDecisions.Clear();




            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("getMedicaments", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;



            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();



            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string depotMed = SqlExec["MED_DEPOTLEGAL"].ToString();
                string nomComMed = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string famCode = SqlExec["MED_FAM_CODE"].ToString();
                string compMed = SqlExec["MED_COMPOSITION"].ToString();
                string effetMed = SqlExec["MED_EFFETS"].ToString();
                string contreIndicMed = SqlExec["MED_CONTREINDIC"].ToString();
                string amm = SqlExec["MED_AMM"].ToString();





                Medicament leMedicament = new Medicament(depotMed, nomComMed, famCode, compMed, effetMed, contreIndicMed, amm);





                Globale.lesMedicaments.Add(depotMed, leMedicament);



                Globale.lesMedicaments[depotMed].getLesEtapes().Clear();




                //gestion des factures du workflow
                SqlCommand maRequeteWorkflow = new SqlCommand("prc_afficherWorkflowEtapeNormeesMedicament", Globale.cnx);
                maRequeteWorkflow.CommandType = System.Data.CommandType.StoredProcedure;
                // Ajouter les parameters à la procédure stockée
                SqlParameter paramDepotLegal = new SqlParameter("@depotlegal", System.Data.SqlDbType.Char, 30);
                paramDepotLegal.Value = depotlegal;
                maRequeteWorkflow.Parameters.Add(paramDepotLegal);



                SqlDataReader SqlExecWorkflow = maRequeteWorkflow.ExecuteReader();


>>>>>>> feature_clement

                // boucle de lecture des differentes informations du medicament avec ajout dans leurs collections respectives
                while (SqlExecWorkflow.Read())
                {
<<<<<<< HEAD
                    int numEtape = (int)SqlExecWorkflow["ETP_NUM"];
=======



                    int numEtape = (int)SqlExecWorkflow["WRK_ETP_NUM"];
>>>>>>> feature_clement
                    string libelleEtape = SqlExecWorkflow["ETP_LIBELLE"].ToString();
                    DateTime dateDecison = DateTime.Parse(SqlExecWorkflow["WRK_DATE_DECISION"].ToString());
                    int idDecision = (int)SqlExecWorkflow["DCS_ID"];
                    string libelleDecision = SqlExecWorkflow["DCS_LIBELLE"].ToString();
                    string etapeNorme = SqlExecWorkflow["ETP_NORME"].ToString();
                    DateTime etapeDateNorme = DateTime.Parse(SqlExecWorkflow["ETP_DATE_NORMEE"].ToString());
                    string depotLegal = SqlExecWorkflow["ETP_LIBELLE"].ToString();

                    

                    Etape uneEtape;

<<<<<<< HEAD
                    if (etapeNorme != "" && etapeDateNorme != null)
                    {
=======
                 
>>>>>>> feature_clement
                        uneEtape = new EtapeNormee(numEtape, libelleEtape, etapeNorme, etapeDateNorme);
                    
                  



                    Workflow leWorkflow = new Workflow(dateDecison, numEtape, idDecision, depotLegal);
                    Decision laDecision = new Decision(idDecision, libelleDecision);



                    Globale.lesMedicaments[depotMed].getLesEtapes().Add(leWorkflow);
                    Globale.lesEtapes.Add(uneEtape);
                    Globale.lesDecisions.Add(laDecision);



                }

            }


        }
        public static void LireLeWorkFlowDunMed(string depotlegal)
        {
            Globale.lesEtapes.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("getWorkflow", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter paramDepotLegal = new SqlParameter("@depotlegal", System.Data.SqlDbType.Char, 30);
            paramDepotLegal.Value = depotlegal;
            maRequete.Parameters.Add(paramDepotLegal);

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int wrkEtpNum = Convert.ToInt32(SqlExec["WRK_ETP_NUM"]);
                string wrkMedDepotLegal = SqlExec["WRK_MED_DEPOTLEGAL"].ToString();
                DateTime dateDecison = DateTime.Parse(SqlExec["WRK_DATE_DECISION"].ToString());
                int idDecision = Convert.ToInt32(SqlExec["WRK_DCS_ID"]);





                Workflow workflow = new Workflow(dateDecison, wrkEtpNum, idDecision, wrkMedDepotLegal);
                Globale.lesMedicaments[depotlegal].getLesEtapes().Add(workflow);





            }
        }


        public static void etapesWorkflow(string depotlegal)
        {



            Globale.lesMedicaments.Clear();

            Globale.lesDecisions.Clear();




            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("getMedicaments", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;



            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();



            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string depotMed = SqlExec["MED_DEPOTLEGAL"].ToString();
                string nomComMed = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string famCode = SqlExec["MED_FAM_CODE"].ToString();
                string compMed = SqlExec["MED_COMPOSITION"].ToString();
                string effetMed = SqlExec["MED_EFFETS"].ToString();
                string contreIndicMed = SqlExec["MED_CONTREINDIC"].ToString();
                string amm = SqlExec["MED_AMM"].ToString();





                Medicament leMedicament = new Medicament(depotMed, nomComMed, famCode, compMed, effetMed, contreIndicMed, amm);





                Globale.lesMedicaments.Add(depotMed, leMedicament);



                Globale.lesMedicaments[depotMed].getLesEtapes().Clear();




                //gestion des factures du workflow
                SqlCommand maRequeteWorkflow = new SqlCommand("prc_afficherWorkflowEtapeMedicament", Globale.cnx);
                maRequeteWorkflow.CommandType = System.Data.CommandType.StoredProcedure;
                // Ajouter les parameters à la procédure stockée
                SqlParameter paramDepotLegal = new SqlParameter("@depotlegal", System.Data.SqlDbType.Char, 30);
                paramDepotLegal.Value = depotlegal;
                maRequeteWorkflow.Parameters.Add(paramDepotLegal);



                SqlDataReader SqlExecWorkflow = maRequeteWorkflow.ExecuteReader();



                while (SqlExecWorkflow.Read())
                {



                    int numEtape = (int)SqlExecWorkflow["WRK_ETP_NUM"];
                    string libelleEtape = SqlExecWorkflow["ETP_LIBELLE"].ToString();
                    DateTime dateDecison = DateTime.Parse(SqlExecWorkflow["WRK_DATE_DECISION"].ToString());
                    int idDecision = (int)SqlExecWorkflow["DCS_ID"];
                    string libelleDecision = SqlExecWorkflow["DCS_LIBELLE"].ToString();
                    string depotLegal = SqlExecWorkflow["ETP_LIBELLE"].ToString();



                    Etape uneEtape;



                  
                        uneEtape = new Etape(numEtape, libelleEtape);
                   



<<<<<<< HEAD
                    Workflow leWorkflow = new Workflow(dateDecison, numEtape, idDecision, depotLegalMed);
=======

                    Workflow leWorkflow = new Workflow(dateDecison, numEtape, idDecision, depotLegal);
>>>>>>> feature_clement
                    Decision laDecision = new Decision(idDecision, libelleDecision);



                    Globale.lesMedicaments[depotMed].getLesEtapes().Add(leWorkflow);
                    Globale.lesEtapes.Add(uneEtape);
                    Globale.lesDecisions.Add(laDecision);
<<<<<<< HEAD
                
                }
        }
=======



                }

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
        public static void lireLesModifs()
        {
            Globale.lesModifs.Clear();

            SqlCommand maRequete = new SqlCommand("prc_afficherHistorique", Globale.cnx); ;
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sqlExec = maRequete.ExecuteReader();

            while (sqlExec.Read())
            {
                string etape = sqlExec["ETP_LIBELLE"].ToString();
                string identifiant = sqlExec["identifiant"].ToString();
                DateTime dateModif = DateTime.Parse(sqlExec["dateModif"].ToString());
                string ancienneNorme = sqlExec["ancienneNorme"].ToString();
                string nouvelleNorme = sqlExec["nouvelleNorme"].ToString();
                DateTime ancienneDate = DateTime.Parse(sqlExec["ancienneDateNorme"].ToString());
                DateTime nouvelleDate = DateTime.Parse(sqlExec["nouvelleDateNorme"].ToString());

                Modif laModif = new Modif(etape, identifiant, dateModif, ancienneNorme, nouvelleNorme, ancienneDate, nouvelleDate);

                Globale.lesModifs.Add(laModif);
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
>>>>>>> feature_clement
    }
}

