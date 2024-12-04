using NomeSobreNomeClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaviAraujoSochaDesk
{
    public partial class FrmCadastrarCliente : Form
    {
        public FrmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void FrmCadastrarCliente_Load(object sender, EventArgs e)
        {
            btnCadastrarCliente.Enabled = true;
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
            
        {
         Cliente cliente = new (
             txtNome.Text,
             txtEmail.Text,
             txttelefone.Text,
             txtEndereco.Text
             );
            cliente.InserirCliente();
            if (cliente.ID > 0)
            {
                // carrega grid
                
                MessageBox.Show($"Usuário {cliente.Nome} inserido com sucesso");
                btnCadastrarCliente.Enabled = false;
            }
            else
            {
                MessageBox.Show("não foi possivel inserir cliente");
            }
        }
    }

 
}
