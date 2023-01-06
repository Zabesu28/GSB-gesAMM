using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETgesAMM
{
    public partial class FormMedicamentEnCours : Form
    {
        public FormMedicamentEnCours()
        {
            InitializeComponent();
        }

        private void FormMedicamentEnCours_Load(object sender, EventArgs e)
        {
            bd.lireLesMedicamentsEnCours(); /* appel la fonction se trouvant dans bd, premettant d'intégrer dans la liste c# les médicaments en cours  */
            foreach (string leCodeMedicament in Globale.lesMedicaments.Keys)
            {
                
                Medicament leMedicament = Globale.lesMedicaments[leCodeMedicament];

                int idx = 0;
                bool trouve = false;
                while(idx < Globale.lesFamilles.Count && !trouve)
                {
                    Famille laFamille = Globale.lesFamilles[idx];
                    if(laFamille.getCode() == leMedicament.getFamCode())
                    {
                        trouve = true;
                        if (leMedicament.getAmm() == "") /* si le médicament est pas encore autorisé on va l'afficher  */
                        {
                            ListViewItem MonEtape = new ListViewItem();
                            MonEtape.Text = leMedicament.getDepotLegal();
                            MonEtape.SubItems.Add(leMedicament.getNomCommercial());
                            MonEtape.SubItems.Add(laFamille.getLibelle());
                            lvMedicament.Items.Add(MonEtape);

                            cbMedicament.Items.Add(leMedicament.getDepotLegal());

                          

                        }    
                        
                    }
                    else
                    {
                        idx++;
                    }

                    
                }
                
            }
        }

        private void chargerListeWorkflowEnCours() /* fonction permettant de afficher la liste des etapes du médicament (en cours) sélectionné */
        {


            if (Globale.lesMedicaments.ContainsKey(cbMedicament.Text)) 
            {
                lvEtapes.Items.Clear();  /* on vide toutes les données à afficher */
                Globale.lesEtapes.Clear();
                Globale.lesDecisions.Clear();
                Globale.lesMedicaments[cbMedicament.Text].getLesEtapes().Clear();


                bd.etapesWorkflow(cbMedicament.Text); /* fonction venant de bd qui va remplir les listes selon le médicament choisit  */

                foreach (Workflow leWorkflow in Globale.lesMedicaments[cbMedicament.Text].getLesEtapes())
                {



                    foreach (Etape lEtape in Globale.lesEtapes)
                    {

                        if (lEtape.getNum() == leWorkflow.getNumEtape())
                        {

                            int idx = 0;
                            foreach (Decision laDecision in Globale.lesDecisions)
                            {


                                if (laDecision.getId() == leWorkflow.getIdDecision() && idx == 0)
                                {
                                    /* ajoute les étapes du médicament dans la listView */

                                    idx++;
                                    ListViewItem MonEtape = new ListViewItem();

                                    DateTime laDate = (lEtape as EtapeNormee).getDateNorme();
                                    string uneDate = (laDate.Day + "/" + laDate.Month + "/" + laDate.Year).ToString();
                                    DateTime laDateDecision = leWorkflow.getDateDecision();
                                    string uneDateDecision = (laDateDecision.Day + "/" + laDateDecision.Month + "/" + laDateDecision.Year).ToString();

                                    MonEtape.Text = lEtape.getNum().ToString();
                                    MonEtape.SubItems.Add(lEtape.getLibelle());
                                    MonEtape.SubItems.Add(uneDateDecision.ToString());
                                    MonEtape.SubItems.Add(laDecision.getLibelle());
                                    MonEtape.SubItems.Add((lEtape as EtapeNormee).getNorme());
                                    MonEtape.SubItems.Add(uneDate.ToString());

                                    lvEtapes.Items.Add(MonEtape);

                                }
                            }

                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Aucune étape n'a été traité sur ce médicament");
            }

        }









        /* charge la liste des etapes d'un medicament quand celui-ci est sélectionné */
        private void cbMedicament_SelectedIndexChanged(object sender, EventArgs e)  
        {
            chargerListeWorkflowEnCours(); 

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
