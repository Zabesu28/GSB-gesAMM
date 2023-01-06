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

        private void etapesNorméesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEtapeNormees form = new FormEtapeNormees();
            form.Show();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEtapesMedicament form = new FormEtapesMedicament();
            form.Show();
        }

        private void etapesEnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedicamentEnCours form = new FormMedicamentEnCours();
            form.Show();
        }
    }
}
