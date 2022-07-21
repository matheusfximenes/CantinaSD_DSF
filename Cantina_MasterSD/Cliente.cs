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
        private String nome { get; set; }
        private String telefone { get; set; }
        private String cpfcnpj { get; set; }
        private String endereco { get; set; }
       
        [Key] 
        public int IdCliente { get; set; }
      


    }
}
