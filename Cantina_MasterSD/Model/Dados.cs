using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_MasterSD
{
    internal class Dados
    {
        public static List<Cliente> Cliente = new List<Cliente>();
        public static List<Quentinha> quentinhas = new List<Quentinha>();
        public static List<Pedido> pedidos = new List<Pedido>();
        public static Cliente usuarioLogado = new Cliente();
        internal static List<Cliente> cliente { get; set; }
        public static object clientes { get; set; }
        public List<Quentinha> GetQuentinha()
        {
            return this.GetQuentinha();
        }

        public void SetQuentinha(List<Quentinha> quentinhas)
        {
            this.SetQuentinha(quentinhas);
        }

        public List<Cliente> GetCliente()
        {
            return this.GetCliente();
        }

        public void SetCliente(List<Cliente> clientes)
        {
            this.SetCliente(clientes);
        }

        public List<Pedido> GetPedido()
        {
            return this.GetPedido();
        }

        public void SetPedido(List<Pedido> pedidos)
        {
            this.SetPedido(pedidos);
        }

    }
}
