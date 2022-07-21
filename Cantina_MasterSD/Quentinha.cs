using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_MasterSD
{
    public class Quentinha
    {
        [Required]
        private String nome { get; set; }
        
        [Required]
        private String descricao { get; set; }  // Conteudo da quentinha
        [Required] 
        private Decimal preco { get; set; }   // Valor

        [Key]
        public int QuentinhaId { get; set; } 
    }
}
