using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_MasterSD
{
    public class Pedido
    {
        private Cliente cliente; // puxa o cliente 
        private List<Quentinha> quentinhas = new List<Quentinha>(); // lista as quentinhas 
        private String status;  // andamento do pedido (aqui podemos verificar se pode cancelar ou não)
        private Decimal preco;

        //Get e Set do cliente
        public Cliente GetCliente()
        {
            return this.cliente;
        }

        public void SetCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        //Get e Set para listar e retornar a quentinha ou as quentinhas.
        public List<Quentinha> GetQuentinhas()
        {
            return this.quentinhas;
        }

        public void SetQuentinhas(List<Quentinha> quentinhas)
        {
            this.quentinhas = quentinhas;
        }

        //Get e Set para o andamento do pedido
        public String GetStatus()
        {
            return this.status;
        }

        public void SetStatus(String status)
        {
            this.status = status;
        }

        //Get e Set do preco
        public Decimal GetPreco()
        {
            return this.preco;
        }

        public void SetPreco(Decimal preco)
        {
            this.preco = preco;
        }


    }
}
