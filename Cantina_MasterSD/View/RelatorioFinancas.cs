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
    public partial class RelatorioFinancas : Form
    {
        public RelatorioFinancas()
        {
            InitializeComponent();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RelatorioFinancas_Load(object sender, EventArgs e)
        {
            Decimal numPedidosRealizados = 0;
            Decimal numPedidosCancelados = 0;
            Decimal totalPedidosRealizados = 0;
            Decimal totalPedidosCancelados = 0;

            foreach (var item in Dados.pedidos)
            {
                if (item.Status == "Cancelado")
                {
                    numPedidosCancelados++;
                    totalPedidosCancelados += item.Preco;
                }
                else
                {
                    numPedidosRealizados++;
                    totalPedidosRealizados += item.Preco;
                }
            }

            nPedidosRealizados.Text = numPedidosRealizados.ToString();
            nPedidosCancelados.Text = numPedidosCancelados.ToString();
            totPedidosRealizados.Text = "R$ " + totalPedidosRealizados.ToString();
            totPedidosCancelados.Text = "R$ " + totalPedidosCancelados.ToString();
            Decimal totalLiquido = totalPedidosRealizados - totalPedidosCancelados;
            totLiquido.Text = "R$ " + totalLiquido.ToString();

        }
    }
}
