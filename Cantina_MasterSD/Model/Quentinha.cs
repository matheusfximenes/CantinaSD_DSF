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
        public String Nome { get; set; }

        public String Descricao { get; set; }  // Conteudo da quentinha
        [Required]
        public Decimal Preco { get; set; }   // Valor

        [Key]
        public int QuentinhaId { get; set; }


    }
}
