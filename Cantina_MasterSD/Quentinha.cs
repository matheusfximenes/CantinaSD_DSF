using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_MasterSD
{
    public class Quentinha
    {
        private String nome;       
        private String descricao;  // Conteudo da quentinha
        private Decimal preco;   // Valor

        //Get e Set para nome
        public String GetNome()
        {
            return this.nome;
        }

        public void SetNome(String nome)
        {
            this.nome = nome;
        }

        //Get e Set para Desc
        public String GetDescricao()
        {
            return this.descricao;
        }

        public void SetDescricao(String descricao)
        {
            this.descricao = descricao;
        }

        //Get e Set para o valor da quentinha
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
