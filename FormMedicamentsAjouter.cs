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
    public partial class FormMedicamentsAjouter : Form
    {
        public FormMedicamentsAjouter()
        {
            InitializeComponent();
        }

        private void verifAjout()
        {
            if(tbDepotLegal.Text != "" && tbNomCommercial.Text != "" && tbComposition.Text != "" && cbFamille.SelectedIndex != 0 && tbEffets.Text != "" && tbContreIndication.Text != "")
            {
                btnAjouter.Enabled = true;
            }
            else
            {
                btnAjouter.Enabled = false;
            }
        }

        private void FormMedicamentsAjouter_Load(object sender, EventArgs e)
        {
            btnAjouter.Enabled = false;
            bd.lireLesFamilles();
            foreach(Famille uneFamille in Globale.lesFamilles)
            {
                cbFamille.Items.Add(uneFamille.getLibelle());
            }
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(bd.insererMedoc(tbDepotLegal.Text, tbNomCommercial.Text, cbFamille.Text, tbComposition.Text, tbEffets.Text, tbContreIndication.Text))
            {
                MessageBox.Show("Médicament inséré !");
            }
            else
            {
                MessageBox.Show("Une erreur est survenue !");
            }
        }

        private void tbDepotLegal_TextChanged(object sender, EventArgs e)
        {
            verifAjout();
        }

        private void tbNomCommercial_TextChanged(object sender, EventArgs e)
        {
            verifAjout();
        }

        private void tbComposition_TextChanged(object sender, EventArgs e)
        {
            verifAjout();
        }

        private void cbFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            verifAjout();
        }

        private void tbEffets_TextChanged(object sender, EventArgs e)
        {
            verifAjout();
        }

        private void tbContreIndication_TextChanged(object sender, EventArgs e)
        {
            verifAjout();
        }
    }
}
