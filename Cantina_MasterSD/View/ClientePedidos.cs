using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_MasterSD.Model
{
    public partial class ClientePedidos : Form
    {
        public ClientePedidos()
        {
            InitializeComponent();

        }
        private void ClientePedidos_Load(object sender, EventArgs e)
        {
            List<Pedido> pedidos = new List<Pedido>();

            for (int i = 0; i < Dados.pedidos.Count; i++)
            {
                if (Dados.usuarioLogado.GetCpfCnpj() == Dados.pedidos[i].GetCliente().GetCpfCnpj())
                {
                    pedidos.Add(Dados.pedidos[i]);
                }
            }

            foreach (var item in pedidos)
            {
                lista_pedidos_cliente.Items.Add(item.GetQuentinhas().Count + " Quentinhas - R$ " + item.GetPreco() + " - " + item.GetStatus());
            }
        }

    }
}
