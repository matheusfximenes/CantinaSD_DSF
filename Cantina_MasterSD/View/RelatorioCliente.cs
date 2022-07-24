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
    public partial class RelatorioCliente : Form
    {
        public RelatorioCliente()
        {
            InitializeComponent();
        }
        private void RemoverCliente_Load(object sender, EventArgs e)
        {
            foreach (var item in Dados.cliente)
            {
                listview_clientes.Items.Add(item.Nome + " - " + item.CpfCnpj + " - " + item.Telefone + " - " + item.Endereco);
            }

            nClientesCadastrados.Text = "Número de clientes cadastrados: " + Dados.cliente.Count();
        }
    }
}
