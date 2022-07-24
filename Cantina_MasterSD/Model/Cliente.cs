using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_MasterSD
{
    public class Cliente
    {
        [Required]
        public String Nome { get; set; }
        [Required]
        public String Telefone { get; set; }
        [Required]
        public String CpfCnpj { get; set; }
        [Required]
        public String Endereco { get; set; }

        [Key]
        public int IdCliente { get; set; }



    }
}
