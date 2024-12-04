using DaviAraujoSochaClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Notice.Warning.Types;

namespace NomeSobreNomeClass
{
    public class Cliente
    {
        public int ID;
        public string Nome {  get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        /// <summary>
        /// construtor Vazio
        /// </summary>
       public Cliente()
        {

        }
        /// <summary>
        /// Construtor com todos os atributos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="telefone"></param>
        /// <param name="endereco"></param>
       public Cliente(int id, string nome, string email, string telefone, string endereco) 
        { 
            ID = id;
            Nome = nome;  
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }
        /// <summary>
        /// contrutor sem o Id
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="telefone"></param>
        /// <param name="endereco"></param>
        public Cliente(string nome, string email, string telefone, string endereco)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }
        
        
        public void InserirCliente()
        {
            var cmd = Banco.abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into Clientes (nome, email, telefone, endereco) VALUES ({Nome},{Email},{Telefone},{Endereco})";
            cmd.ExecuteReader();
            cmd.Connection.Close();

        }
        public bool AtualizarCliente()
        {
            var cmd = Banco.abrir();
            cmd.CommandType= System.Data.CommandType.Text;
            cmd.CommandText = $"update clientes set telefone = '{Telefone}', endereco = '{Endereco}' where id ={ID};";
            var dr = cmd.ExecuteReader();
            cmd.Connection.Close();
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        public static Cliente ObterClientePorId(int id)
        {
            Cliente cliente = new ();
            var cmd = Banco.abrir();
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new (
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4)
                    );
            }
                return cliente;
        }
        public static List<Cliente> ObterListaClientes()
        {
            List<Cliente> lista = new();
            var cmd = Banco.abrir();
            cmd.CommandText = $"select * from clientes order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                      dr.GetInt32(0),
                      dr.GetString(1),
                      dr.GetString(2),
                      dr.GetString(3),
                      dr.GetString(4)
                ));

            }
                return lista;
        }


    }
}

