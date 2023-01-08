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
    public partial class frmMedAutoriseFam : Form
    {
        public frmMedAutoriseFam()
        {
            InitializeComponent();
        }

        private void frmMedAutoriseFam_Load(object sender, EventArgs e)
        {
            lvFamille.Items.Clear();
            lvMedAutoriser.Items.Clear();
            bd.lireLesFamilles();
            bd.lireLesMedicaments();
            foreach(Famille laFamille in Globale.lesFamilles)
            {
               
                    ListViewItem maLigne = new ListViewItem();
                    maLigne.Text = laFamille.getCode().ToString();
                    maLigne.SubItems.Add(laFamille.getLibelle());
                    maLigne.SubItems.Add(laFamille.getNbMediAmm().ToString());
                    lvFamille.Items.Add(maLigne);
                }
            }

        private void lvFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvMedAutoriser.Items.Clear();
            bd.lireLesMedicaments();
            try
            {
                foreach (string leCodeMedicament in Globale.lesMedicaments.Keys)
                {
                    Medicament leMedicament = Globale.lesMedicaments[leCodeMedicament];
                    if(leMedicament.getAmm()=="1")
                    {
                        if (leMedicament.getFamCode().ToString() == lvFamille.SelectedItems[0].Text)
                            {
                                ListViewItem maLigne = new ListViewItem();
                                maLigne.Text = leMedicament.getDepotLegal().ToString();
                                maLigne.SubItems.Add(leMedicament.getNomCommercial().ToString());
                                lvMedAutoriser.Items.Add(maLigne);
                            }
                    }
                   

                }
            }
            catch
            {

            }
           
        }
    }
    }


    

