using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;


namespace Cantina_MasterSD
{
    //conexão com o banco 
    public class DataContext : DbContext
    {
        //Conectando com o banco Cantina
        public DataContext(): base(@"Data Source=(localdb)\MSSQLLocalDB;Initial 
            Catalog=Cantina;Integrated Security=True;Connect 
            Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=R
            eadWrite;MultiSubnetFailover=False")
        { }
        
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Produto> Produtos { get; set; }


    }
}
