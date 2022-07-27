using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maintenance_eptr
{
    class Methode
    {
        //public DataTable dt = new DataTable();
        //public DataTable dt_sousfamille = new DataTable();
        public DataTable dt_materiels = new DataTable();
      //  public DataTable loadmateriels()
        {
            //DataTable dt = new DataTable();
            //con.Open();
            String query = "SELECT Nparc,Designation,Marque,Type,Nserie,immatriculation,dateaquisition,Compteur FROM Materiel ";
            SQLiteCommand cmd = new SQLiteCommand(query, DB.con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt_materiels);
            //con.Close();
            return dt_materiels;

        }
        //insert materiels
        public void insert_Materiel(string nparc, string designation, string marque, string type, string nserie, string immatriculation, string dateaquisition, int compteur)
        {
            //SQLiteCommand cmd = new SQLiteCommand();
            // cmd.Connection = DB.con;
            String query = "INSERT INTO Materiel (Nparc,Designation,Marque,Type,Nserie,immatriculation,dateaquisition,Compteur ) VALUES (@Nparc,@Designation,@Marque,@Type,@Nserie,@immatriculation,@dateaquisition,@Compteur )";
            SQLiteCommand cmd = new SQLiteCommand(query, DB.con);
            cmd.Parameters.AddWithValue("@Nparc", nparc);
            cmd.Parameters.AddWithValue("@Designation",designation );
            cmd.Parameters.AddWithValue("@Marque", marque);
            cmd.Parameters.AddWithValue("@Type", type);
            cmd.Parameters.AddWithValue("@Nserie", nserie);
            cmd.Parameters.AddWithValue("@immatriculation", immatriculation);
            cmd.Parameters.AddWithValue("@dateaquisition", dateaquisition);
            cmd.Parameters.AddWithValue("@Compteur", compteur);

            DB.con.Open();
            dt_materiels.Load(cmd.ExecuteReader());




        }
   

    }
}
