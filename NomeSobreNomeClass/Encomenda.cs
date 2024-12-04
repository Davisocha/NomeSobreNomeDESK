using DaviAraujoSochaClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NomeSobreNomeClass
{
    public class Encomenda
    {
        public int Encomenda_id { get; set; }
        public Cliente? Cliente_id {get; set;}
        public DateTime Data_encomenda{ get; set;}
        public string Status { get; set;}
        public DateTime Data_entrega { get; set; }

        public Encomenda () 
        {
             Cliente_id  = new();
        }
         public Encomenda(int encomenda_id,Cliente?  cliente_id, DateTime data_encomenda, string status, DateTime data_entrega)
        {
            Encomenda_id = encomenda_id;
            Cliente_id = cliente_id;
            Data_encomenda = data_encomenda;
            Status = status;
            Data_entrega = data_entrega;
        }
        public Encomenda( Cliente? cliente_id, DateTime data_encomenda, string status, DateTime data_entrega)
        {
            
            Cliente_id = cliente_id;
            Data_encomenda = data_encomenda;
            Status = status;
            Data_entrega = data_entrega;
        }
         public void InserirNovaEncomenda()
        {
            var cmd = Banco.abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into Encomendas (id_cliente, data_encomenda, status, data_entrega) VALUES ({Cliente_id},{Data_encomenda},{Status},{Data_entrega})";
            cmd.ExecuteReader();
            cmd.Connection.Close();
        }
        public bool AlterarEncomenda()
        {
            var cmd = Banco.abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update Encomendas set status = '{Status}',  data_entrega = '{Data_entrega}' where id ={Encomenda_id};";
            var dr = cmd.ExecuteReader();
            cmd.Connection.Close();
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        public static Encomenda ObterEncomendaPorId(int id)
        {
            Encomenda encomenda = new();
            var cmd = Banco.abrir();
            cmd.CommandText = $"select * from encomendas where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                encomenda = new(
                    dr.GetInt32(0),
                    Cliente.ObterClientePorId(dr.GetInt32(1)),
                    dr.GetDateTime(2),
                    dr.GetString(3),
                    dr.GetDateTime(4)
                    );
            }
            return encomenda;
        }
        public static List<Encomenda> ObterListaEncomendas()
        {
            List<Encomenda> lista = new();
            var cmd = Banco.abrir();
            cmd.CommandText = $"select * from Encomendas order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                      dr.GetInt32(0),
                    Cliente.ObterClientePorId(dr.GetInt32(1)),
                    dr.GetDateTime(2),
                    dr.GetString(3),
                    dr.GetDateTime(4)
                ));

            }
            return lista;
        }







    }
}
