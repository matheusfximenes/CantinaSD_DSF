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
    public partial class RelatorioPedidos : Form
    {
        public RelatorioPedidos()
        {
            InitializeComponent();
        }
        private void RelatorioPedidos_Load(object sender, EventArgs e)
        {
            foreach (var item in Dados.pedidos)
            {
                listview_pedidos.Items.Add(item.Cliente.Nome + " - R$ " + item.Preco + " - " + item.Status);
            }

            nPedidosFeitos.Text = "Número de pedidos feitos: " + Dados.pedidos.Count();
        }
    }
}
