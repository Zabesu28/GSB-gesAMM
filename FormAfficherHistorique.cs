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
    public partial class FormAfficherHistorique : Form
    {
        public FormAfficherHistorique()
        {
            InitializeComponent();
        }

        private void FormAfficherHistorique_Load(object sender, EventArgs e)
        {
            ChargerListeModifs();
        }

        private void ChargerListeModifs()
        {
            lvHisto.Items.Clear();

            bd.lireLesModifs();

            foreach (Modif uneModif in Globale.lesModifs)
            {

                ListViewItem laModif = new ListViewItem();
                laModif.Text = uneModif.getEtape();
                laModif.SubItems.Add(uneModif.getUser());
                laModif.SubItems.Add(uneModif.getDateModif().ToString("d"));
                laModif.SubItems.Add(uneModif.getAncienneNorme());
                laModif.SubItems.Add(uneModif.getNouvelleNorme());
                laModif.SubItems.Add(uneModif.getAncienneDate().ToString("d"));
                laModif.SubItems.Add(uneModif.getNouvelleDate().ToString("d"));

                lvHisto.Items.Add(laModif);
            }
        }
    }
}
