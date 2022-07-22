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
    public partial class CancelarPedido : Form
    {
        public CancelarPedido()
        {
            InitializeComponent();
        }

        private void CancelarPedido_Load(object sender, EventArgs e)
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
                combo_pedidos.Items.Add(item.GetQuentinha().Count + " Quentinhas - R$ " + item.GetPreco() + " - " + item.GetStatus());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dados.pedidos[combo_pedidos.SelectedIndex].SetStatus("Cancelado");
            this.Close();
        }
    }
}
