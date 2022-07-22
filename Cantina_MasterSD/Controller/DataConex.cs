using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cantina_MasterSD
{
    //conexão com o banco 
    public class DataContext : DbContext
    {
        //Conectando com o banco Cantina
        public DataContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Cantina2;Integrated Security=True;Connect Timeout=30;
        Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        { }


        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Quentinha> Quentinha { get; set; }
        internal DbSet<Dados> Dados { get; }
    }
}
