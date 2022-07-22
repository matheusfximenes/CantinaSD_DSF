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
        internal static IEnumerable<object> cliente;
        public static object clientes;

       
    }
}
