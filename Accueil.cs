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
<<<<<<< HEAD
            Globale.cnx.ConnectionString = "Data Source=BTS2021-32\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True";
=======
            Globale.cnx.ConnectionString = "Data Source=BTS2021-13\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True";
>>>>>>> feature_clement
            Globale.cnx.Open();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (bd.ConnexionUtilisateurs(tbId.Text, tbMdp.Text)) 
            {
                Menu frmMenu = new Menu();
                frmMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Identifiant et/ou mot de passe éronné");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
=======
            Menu Menu = new Menu();
            Menu.Show();
>>>>>>> feature_clement
            this.Hide();
        }
    }
}
