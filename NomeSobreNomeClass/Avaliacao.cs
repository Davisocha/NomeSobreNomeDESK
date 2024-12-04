using DaviAraujoSochaClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NomeSobreNomeClass
{
    public class Avaliacao
    {
        public int Avaliacao_Id { get; set; }
        public Placa Placa { get; set; }
        public Cliente Cliente { get; set; }
        public string Nota { get; set; }
        public string Comentario { get; set; }

        public Avaliacao() {
            Placa = new();
            Cliente = new();
        }
        public Avaliacao(int avaliacao, Placa placa, Cliente cliente, string nota, string comentario)
        {
            Avaliacao_Id = avaliacao;
            Placa = placa;
            Cliente = cliente;
            Nota = nota;
            Comentario = comentario;
        }
        public Avaliacao(Placa placa, Cliente cliente, string nota, string comentario)
        {
            Placa = placa;
            Cliente = cliente;
            Nota = nota;
            Comentario = comentario;
        }
        public void InserirAvaliacao()
        {
            var cmd = Banco.abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into Avaliacao (id_cliente, id_placa, nota, comentario) VALUES ({Cliente},{Placa},{Nota},{Comentario})";
            cmd.ExecuteReader();
            cmd.Connection.Close();
        }
        public bool AlterarAvaliacao()
        {
            var cmd = Banco.abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update Avaliacao set Nota = '{Nota}',comentario = '{Comentario}' where id ={Avaliacao_Id};";
            var dr = cmd.ExecuteReader();
            cmd.Connection.Close();
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        public static Avaliacao ObterAvaliacaoPorId(int id)
        {
            Avaliacao avaliacao = new();
            var cmd = Banco.abrir();
            cmd.CommandText = $"select * from avaliacao where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                avaliacao = new(
                    dr.GetInt32(0),
                    Placa.ObterPlacaPorId(dr.GetInt32(1)),
                    Cliente.ObterClientePorId(dr.GetInt32(2)),
                    dr.GetString(3),
                    dr.GetString(4)
                    );
            }
            return avaliacao;


                   
        }
        public static List<Avaliacao> ObterListaAvaliacao()
        {
            List<Avaliacao> lista = new();
            var cmd = Banco.abrir();
            cmd.CommandText = $"select * from avaliacao order by nota asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                    dr.GetInt32(0),
                    Placa.ObterPlacaPorId(dr.GetInt32(1)),
                    Cliente.ObterClientePorId(dr.GetInt32(2)),
                    dr.GetString(3),
                    dr.GetString(4)
                ));

            }
            return lista;
        }
    }
    
}
