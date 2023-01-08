using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETgesAMM {

    class Globale
    {
        public static SqlConnection cnx;
        public static List<Famille> lesFamilles = new List<Famille>();
        public static Dictionary<string, Medicament> lesMedicaments = new Dictionary<string, Medicament>();
        public static List<Etape> lesEtapes = new List<Etape>();
        public static List<Decision> lesDecisions = new List<Decision>();
        public static List<EtapeNormee> lesEtapesNormees = new List<EtapeNormee>();
        public static int idUser;
        public static List<Modif> lesModifs = new List<Modif>();


    }
}
