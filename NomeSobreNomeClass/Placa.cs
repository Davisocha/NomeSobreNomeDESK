using DaviAraujoSochaClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NomeSobreNomeClass
{
    public class Placa
    {
        public int Placa_id { get; set; }
        public string Tipo { get; set; }
        public string Tamanho { get; set; }
        public double Preco { get; set; }

        public Placa() { }
        public Placa (int placa_id, string tipo, string tamanho, double preco)
        {
            Placa_id = placa_id;
            Tipo = tipo;
            Tamanho = tamanho;
            Preco = preco;

        }
        public Placa( string tipo, string tamanho, double preco)
        {
             
            Tipo = tipo;
            Tamanho = tamanho;
            Preco = preco;
        }

        public void InserirPlaca()
        {
            var cmd = Banco.abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into Placas (tipo, tamanho, preco) VALUES ({Tipo},{Tamanho},{Preco})";
            cmd.ExecuteReader();
            cmd.Connection.Close();
        }
        public bool Alterarplaca()
        {
            var cmd = Banco.abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update placas set tipo = '{Tipo}',tamanho = '{Tamanho}', preco = {Preco} where id ={Placa_id};";
            var dr = cmd.ExecuteReader();
            cmd.Connection.Close();
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        public static Placa ObterPlacaPorId(int id)
        {
            Placa placa = new();
            var cmd = Banco.abrir();
            cmd.CommandText = $"select * from placas where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                placa = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3)
                    );
                    
            }
            return placa;
        }
        public static List<Placa> ObterListaEncomendas()
        {
            List<Placa> placas = new();
            var cmd = Banco.abrir();
            cmd.CommandText = $"select * from Placas order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                placas.Add(new(
                      dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3)
                ));

            }
            return placas;
        }
    }
}
