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
    public partial class frmSaisieDecisionEtap : Form
    {
        public frmSaisieDecisionEtap()
        {
            InitializeComponent();
        }



        private void frmSaisieDecisionEtap_Load(object sender, EventArgs e)
        {
            
            cbDecision.Items.Add("Validé");
            cbDecision.Items.Add("Refusé");
            bd.lireLesMedicaments();
            foreach (string leCodeMedicament in Globale.lesMedicaments.Keys)
            {
                Medicament leMedicament = Globale.lesMedicaments[leCodeMedicament];
                cbMed.Items.Add(leMedicament.getDepotLegal());

            }
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            
        }


        private void cbDecision_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnValider.Enabled = true;
        }


        private void cbMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbLastEtapDate.Text = "";
            tbLastEtapDateNorme.Text = "";
            tbLastEtapLibelle.Text = "";
            tbLastEtapNum.Text = "";
            tbLastEtapNorme.Text = "";
            dtpDatePicker.Enabled = false;
            cbDecision.Enabled = false;
            btnValider.Enabled = false;
            bd.lireLesMedicaments();
            int mbTuPePa = 0;


            if (Globale.lesMedicaments[cbMed.Text].getDerniereEtape() == 0)
            {
                dtpDatePicker.Enabled = true;

                cbDecision.Enabled = true;


                //_____________________fill____________________________
                tbLastEtapNum.Text = "0";
                tbActualEtapNum.Text = "1";
                tbActualEtapLibelle.Text = "Définition du protocole de validation";
                
            }

            if (Globale.lesMedicaments.ContainsKey(cbMed.Text))
            {

                bd.lireLesEtapes();
                //bd.LireLeWorkFlowDunMed(cbMed.Text);
                bd.etapesWorkflowNormees(cbMed.Text);
                bd.etapesWorkflow(cbMed.Text);


                foreach (Workflow leWorkflow in Globale.lesMedicaments[cbMed.Text].getLesEtapes())
                {



                    foreach (Etape lEtape in Globale.lesEtapes)
                    {
                        if (lEtape.getNum() == Globale.lesMedicaments[cbMed.Text].getDerniereEtape())
                        {

                            tbLastEtapNum.Text = lEtape.getNum().ToString();

                            tbLastEtapLibelle.Text = lEtape.getLibelle();

                            tbLastEtapDate.Text = leWorkflow.getDateDecision().ToShortDateString().ToString();

                            if (Globale.lesEtapes.Contains((lEtape as EtapeNormee)))
                            {
                                DateTime laDate = (lEtape as EtapeNormee).getDateNorme();
                                string uneDate = (laDate.Day + "/" + laDate.Month + "/" + laDate.Year).ToString();
                                tbLastEtapNorme.Text = ((lEtape as EtapeNormee).getNorme());
                                tbLastEtapDateNorme.Text = (uneDate.ToString());

                                
                                
                            }
                            


                            if (leWorkflow.getIdDecision() == 2 && mbTuPePa == 0)
                            {
                                MessageBox.Show("Dernières étapes refuser impossible d'ajouter une nouvelle étape.");
                                mbTuPePa = 1;
                            }
                            if (Globale.lesMedicaments[cbMed.Text].getDerniereEtape() == 8 && mbTuPePa == 0)
                            {
                                MessageBox.Show("Ce médicament à toutes ses étapes de complétée vous ne pouvez pas en ajouter.");
                                mbTuPePa = 1;
                            }
                            
                            if ((leWorkflow.getIdDecision() == 1 && Globale.lesMedicaments[cbMed.Text].getDerniereEtape() < 8 && mbTuPePa == 0))
                            {
                                mbTuPePa = 1;
                                
                                dtpDatePicker.Enabled = true;
                               
                                cbDecision.Enabled = true;


                                //_____________________fill____________________________
                                Etape newEtp = Globale.lesEtapes[lEtape.getNum()];
                                tbActualEtapNum.Text = newEtp.getNum().ToString();
                                tbActualEtapLibelle.Text = newEtp.getLibelle();

                                if (newEtp.getNum()==3 )
                                {
                                    tbActualEtapNorme.Text = "726/2004/CEE";

                                    tbActualEtapDateNorme.Text = "2004-05-12";

                                }
                                if (newEtp.getNum() == 5)
                                {
                                    tbActualEtapNorme.Text = "180/2012/CEE";

                                    tbActualEtapDateNorme.Text = "2012-01-05";

                                }
                                if (newEtp.getNum() == 7)
                                {
                                    tbActualEtapNorme.Text = "457/2008/CEE";

                                    tbActualEtapDateNorme.Text = "2008-03-15";

                                }
                                if (newEtp.getNum() == 8)
                                {
                                    tbActualEtapNorme.Text = "665/2005/CEE";

                                    tbActualEtapDateNorme.Text = "2005-04-30";

                                }


                            }
                        }
                        
                    }

                }
            }


        }

        private void cbDecision_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnValider.Enabled = true;
        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            int idDecision;
            int numActualEtap = Convert.ToInt32(tbLastEtapNum.Text) + 1;
            if (cbDecision.Text == "Validé")
            {
                idDecision = 1;
            }
            else
            {
                idDecision = 2;
            }
            try
            {
            bd.inseretDecisionEtape(cbMed.Text, numActualEtap, dtpDatePicker.Value, idDecision);
            MessageBox.Show("étapes enregistré");
            btnValider.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Erreur dans les données");
            }
            
        }
    }
}

        










        

        
