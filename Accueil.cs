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
            Globale.cnx.ConnectionString = "Data Source=BTS2021-13\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True";
            Globale.cnx.Open();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();
        }
    }
}
