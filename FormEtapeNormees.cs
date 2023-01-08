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
    public partial class FormEtapeNormees : Form
    {
        public FormEtapeNormees()
        {
            InitializeComponent();
        }

        private void FormEtapeNormees_Load(object sender, EventArgs e)
        {
            chargerEtapesNormees();
            cacher();
        }

        private void cacher()
        {
            btnValider.Enabled = false;
            btnValider.Visible = false;
            lbDateNormee.Visible = false;
            lbNorme.Visible = false;
            dtpDateNormee.Visible = false;
            tbNorme.Visible = false;
            tbNorme.Text = "";
        }

        private void afficher()
        {
            btnValider.Visible = true;
            lbDateNormee.Visible = true;
            lbNorme.Visible = true;
            dtpDateNormee.Visible = true;
            tbNorme.Visible = true;
        }

        private void chargerEtapesNormees()
        {
            lvEtapeNormee.Items.Clear();

            bd.lireLesEtapesNormees();

            foreach (EtapeNormee uneEtapeNormee in Globale.lesEtapesNormees)
            {
                ListViewItem newEtapeNormee = new ListViewItem();
                newEtapeNormee.Text = uneEtapeNormee.getNum().ToString();
                newEtapeNormee.SubItems.Add(uneEtapeNormee.getNorme());
                newEtapeNormee.SubItems.Add(uneEtapeNormee.getDateNorme().ToString("d"));
                lvEtapeNormee.Items.Add(newEtapeNormee);
            }
        }

        private void tbNorme_TextChanged(object sender, EventArgs e)
        {
            if(tbNorme.Text != "")
            {
                btnValider.Enabled = true;
            }
            else
            {
                btnValider.Enabled = false;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem norme = lvEtapeNormee.Items[lvEtapeNormee.FocusedItem.Index];
                bd.majEtapeNormee(int.Parse(norme.SubItems[0].Text), Globale.idUser, norme.SubItems[1].Text, tbNorme.Text, DateTime.Parse(norme.SubItems[2].Text), dtpDateNormee.Value);
                MessageBox.Show("Norme modifiée avec succès !");
                chargerEtapesNormees();
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue, veuillez réessayer !");
            }
            
        }

        private void lvEtapeNormee_SelectedIndexChanged(object sender, EventArgs e)
        {
            afficher();
        }
    }
}
