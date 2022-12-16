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
            bd.lireLesMedicaments();
            cbMed.Items.Clear();

            foreach (Medicament leMedicament in Globale.lesMedicaments.Values)
            {
                cbMed.Items.Add(leMedicament.getNomCommercial());
            }
        }

        private void cbMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.lireLesMedicaments();
            bd.etapesWorkflow();
            foreach (string leCodeMedicament in Globale.lesMedicaments.Keys)
            {
                Medicament leMedicament = Globale.lesMedicaments[leCodeMedicament];

                if (leMedicament.getNomCommercial()==cbMed.Text)
                {
                    Etape etap = Globale.lesEtapes[leMedicament.getDerniereEtape()];

        

                                               
                            
                            tbLastEtapNum.Text = etap.getNum().ToString();
                            tbLastEtapLibelle.Text = etap.getLibelle();
                            
                        
                    
                    
                }
            }
            
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {


            }
            catch
            {

            }
        }
    }
}
