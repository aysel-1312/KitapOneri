using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace VIZEODEV2
{
    public class DBıslemlercs
    {
        static String DByolu = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Atom\Documents\VİZE.mdf;Integrated Security=True;Connect Timeout=30";
    }
   /* public static bool yoneticigiris(string e, string sif)
        {
            bool result = false;
            string sql = "SELECT * FROM yoneticitab WHERE yoneticiadi='" + e + "' and yoneticisifre='" + sif + "'";
            SqlConnection conn = new SqlConnection(DByolu);
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@k", e);
            komut.Parameters.AddWithValue("@s", sif);
            conn.Open();
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                conn.Close();
                result = true;
            }
            else
            {
                conn.Close();
            }


            return result;
        }*/

}