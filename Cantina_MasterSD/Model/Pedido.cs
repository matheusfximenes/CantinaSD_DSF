using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_MasterSD
{
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }

        public List<Cliente> clientes = new List<Cliente>();// puxa o cliente 

        public List<Quentinha> quentinhas = new List<Quentinha>();// lista as quentinhas 
        public String Status { get; set; }  // andamento do pedido (aqui podemos verificar se pode cancelar ou não)
        public Decimal Preco { get; set; }
        public Cliente Cliente { get; internal set; }
        public Quentinha Quentinha{ get; internal set; }

        public List<Quentinha> GetQuentinha()
        {
            return this.quentinhas;
        }

        public void SetQuentinha(List<Quentinha> quentinhas)
        {
            this.quentinhas = quentinhas;
        }

        public List<Cliente> GetCliente()
        {
            return this.clientes;
        }

        public void SetCliente(List<Cliente> clientes)
        {
            this.clientes = clientes;
        }

    }
}
