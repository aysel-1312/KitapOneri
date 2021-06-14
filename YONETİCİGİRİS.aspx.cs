using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;



namespace VIZEODEV2
{
    public partial class YONETİCİGİRİS : System.Web.UI.Page
    {
        
           
        protected void Button1_Click(object sender, EventArgs e)

        { 
            SqlConnection baglantiNesnesi = new SqlConnection();
            //baglantiNesnesi.ConnectionString = baglanti;
            baglantiNesnesi.Open();
            SqlCommand komut = new SqlCommand("Select  From yoneticitab where yoneticiadi ='" + TextBox1.Text + "'", baglantiNesnesi);


            SqlDataReader okuyucu = komut.ExecuteReader();

           if (okuyucu.Read())
            {

                if (TextBox1.Text.ToString() == okuyucu["yoneticiadi"].ToString())
                {
                    komut.Parameters.AddWithValue("@yoneticiadi", TextBox1.Text);
                    if (TextBox2.Text.ToString() == okuyucu["yoneticisifre"].ToString())
                    {

                        YONETİCİGOREVLERİ yg=new YONETİCİGOREVLERİ();
                        yg.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Şifreyi yanlış girdiniz");
                }
               
            }
           else

            MessageBox.Show("Böyle Bir Kullanıcı Adı Bulunmamaktadır");

            baglantiNesnesi.Close();
        }

          /*  string yonetici = TextBox1.Text;
            string sifrem = TextBox2.Text;

            bool ygirisislemi = DBıslemlercs.yoneticigiris(yonetici, sifrem);
            if (ygirisislemi)
            {
                YONETİCİGOREVLERİ tb = new YONETİCİGOREVLERİ();
                tb.Show();
               
            }
            else
            {
                MessageBox.Show("Bilgilerinizde eksiklik veya Yanlışlık Vardır.");
            }*/
        }
    }
}