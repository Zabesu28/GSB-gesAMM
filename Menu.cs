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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void consulatationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMédicaments frmMedoc = new FormMédicaments();
            
            frmMedoc.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void insertionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedicamentsAjouter form = new FormMedicamentsAjouter();
            form.Show();
        }

        private void nombreDeMédicamentAutoriséToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedAutoriseFam frmMedAuto = new frmMedAutoriseFam();
            
            frmMedAuto.Show();
            this.Hide();
        }

        private void saisieDeLaDécisionDuneEtapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaisieDecisionEtap frmSaisieEtap = new frmSaisieDecisionEtap();

            frmSaisieEtap.Show();
            this.Hide();
        }

        private void etapeMedicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEtapesMedicament frmEtpMed = new FormEtapesMedicament();

            frmEtpMed.Show();
            this.Hide();
        }

        private void enCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedicamentEnCours frmEtpMed = new FormMedicamentEnCours();
            frmEtpMed.Show();
            this.Hide();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEtapeNormees form = new FormEtapeNormees();
            form.Show();
        }

        private void historiqueDesModificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAfficherHistorique form = new FormAfficherHistorique();
            form.Show();
        }
    }
}
