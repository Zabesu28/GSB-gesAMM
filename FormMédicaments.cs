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
    public partial class FormMédicaments : Form
    {
        public FormMédicaments()
        {
            InitializeComponent();
        }

        private void chargerListeMedoc()
        {
            lvMedoc.Items.Clear();

            bd.lireLesMedicaments();

            foreach (string leCodeMed in Globale.lesMedicaments.Keys)
            {
                Medicament leMedoc = Globale.lesMedicaments[leCodeMed];
                ListViewItem monMedoc = new ListViewItem();
                monMedoc.Text = leMedoc.getDepotLegal().ToString();
                monMedoc.SubItems.Add(leMedoc.getNomCommercial());
                monMedoc.SubItems.Add(leMedoc.getFamCode());
                monMedoc.SubItems.Add(leMedoc.getComposition());
                monMedoc.SubItems.Add(leMedoc.getEffets());
                monMedoc.SubItems.Add(leMedoc.getContreIndications());
<<<<<<< HEAD
                monMedoc.SubItems.Add(leMedoc.getAmm());
=======
                monMedoc.SubItems.Add(leMedoc.getAmm().ToString());
>>>>>>> feature_clement
                lvMedoc.Items.Add(monMedoc);
            }
        }

        private void FormMédicaments_Load(object sender, EventArgs e)
        {
            chargerListeMedoc();
        }
    }
}
