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

        private Cliente cliente { get; set; } // puxa o cliente 
        
        private List<Quentinha> quentinhas = new List<Quentinha>();// lista as quentinhas 
        private String status { get; set; }  // andamento do pedido (aqui podemos verificar se pode cancelar ou não)
        private Decimal preco { get; set; }




    }
}
