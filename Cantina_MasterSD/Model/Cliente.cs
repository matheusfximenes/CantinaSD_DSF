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
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String CpfCnpj { get; set; }

        public String Endereco { get; set; }

        [Key]
        public int IdCliente { get; set; }



    }
}
