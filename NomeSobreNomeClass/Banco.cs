using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DaviAraujoSochaClass
{
    public class Banco
    {
        public static MySqlCommand abrir(int cod = 0)
        {
            string strcon = @"server=127.0.0.1;database=sistemadeencomendasplacas;user=root;password=";
            MySqlConnection cn = new(strcon);
            MySqlCommand cmd = new();
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return cmd;
        }

    }
}
