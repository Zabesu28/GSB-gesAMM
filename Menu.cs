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

        private void insertionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void etapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEtapesMedicament frmEtapes = new FormEtapesMedicament();
            frmEtapes.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void enCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedicamentEnCours frmMedEC = new FormMedicamentEnCours();
            frmMedEC.Show();
        }
    }
}
