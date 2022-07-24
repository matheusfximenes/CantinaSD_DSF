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
    public partial class AutenticacaoCliente : Form
    {
        public AutenticacaoCliente()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Dados.cliente)
            {
                if (input_cpf.Text == item.CpfCnpj)
                {
                    Dados.usuarioLogado = item;
                    PainelCliente pCliente = new PainelCliente();
                    pCliente.ShowDialog();
                    this.Close();
                }
                else
                {
                    mensagem_autenticacao.Text = "CPF ou CNPJ não constam na base de dados!";
                }
            }
        }

        private void input_cpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
