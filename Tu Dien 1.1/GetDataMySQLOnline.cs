using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Tu_Dien_1._1
{
    class GetDataMySQLOnline
    {

       // static public MySqlConnection conn = new MySqlConnection(@"server=us-cdbr-iron-east-02.cleardb.net;user=b85cd2c739eac7;database=heroku_773852a584ea159;port=3306;password=6cb1f3d8;charset=utf8;");
        
        static public DataTable loadDL()
        {
            DataTable da = new DataTable();
            try
            {

          //      conn.Open();
           //     MySqlDataAdapter dataAp = new MySqlDataAdapter("select * from data_user", conn);
                DataSet ds = new DataSet();
         //       dataAp.Fill(ds,"ViDu");
                da =ds.Tables[0];
         //       conn.Close();
                return da;

            }
            catch
            {
       //         conn.Close();
                return tb.table;
            }
            finally
            {

        //        conn.Close();
            }
        }

        public static void inSertdatamysql(string user, int dung, int sai, string status)
        {
            float tile = 0;
            try
            {


            
                
                    tile = dung-sai;
                
                //This is my connection string i have assigned the database file address path

                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into heroku_773852a584ea159.data_user(iuser,idung,isai,itile,istatus) values('" + user + "','" + dung + "','" + sai + "','" + tile + "','" + status + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.

                //This is command class which will handle the query and connection object.
           //     MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
            //    MySqlDataReader MyReader2;
            //    conn.Open();
             //   MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.

           //     while (MyReader2.Read())
                {
                }
                //conn.Close();

            }
            catch 
            {
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string Query = "update heroku_773852a584ea159.data_user set iuser='" + user + "',idung='" + dung + "',isai='" + sai + "',itile='" + tile + "',istatus='" + status + "' where iuser='" + user + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
             //   MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
              //  MySqlDataReader MyReader2;
                //conn.Open();
           //     MyReader2 = MyCommand2.ExecuteReader();

            //    while (MyReader2.Read())
                {

                }
          //      conn.Close();
                //Connection closed here
            }
            finally
            {
           //     conn.Close();
            }
        }
    }
}
