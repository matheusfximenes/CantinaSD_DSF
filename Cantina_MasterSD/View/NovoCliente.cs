using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_MasterSD.Model
{
    public partial class NovoCliente : Form
    {
        public NovoCliente()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void salvar_cliente_Click(object sender, EventArgs e)
        {
            String nome = nome_cliente.Text;
            String cpj_cnpj = cpf_cnpj_cliente.Text;
            String telefone = telefone_cliente.Text;
            String endereco = endereco_cliente.Text;

            Cliente cli = new Cliente();
            cli.Nome=(nome);
            cli.CpfCnpj=(cpj_cnpj);
            cli.Telefone=(telefone);
            cli.Endereco=(endereco);

            Dados.cliente.Add(cli);

            this.Close();
        }

        private void NovoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
