using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETgesAMM {

    class Globale
    {
        public static SqlConnection cnx; /* Chemin d'accès vers SQL server */
        public static List<Famille> lesFamilles = new List<Famille>();
        public static Dictionary<string, Medicament> lesMedicaments = new Dictionary<string, Medicament>();
        public static List<Etape> lesEtapes = new List<Etape>();
        public static List<Decision> lesDecisions = new List<Decision>();

    }
}
