using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJETgesAMM
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            this.tbMdp.PasswordChar = '*';
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            Globale.cnx = new System.Data.SqlClient.SqlConnection();
            Globale.cnx.ConnectionString = "Data Source=BTS2021-31\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True";
            Globale.cnx.Open();
            tbMdp.Text = "Jxq€958trente-six";
            tbId.Text = "FrancinePoireaux";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbMdp.Text == "Jxq€958trente-six" && tbId.Text=="FrancinePoireaux") 
            {
                Menu frmMenu = new Menu();
                frmMenu.Show();
                this.Hide();
            }
        }
    }
}
