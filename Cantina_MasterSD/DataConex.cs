using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;


namespace Cantina_MasterSD
{
    public class DataContext : DbContext
    {
        public DataContext(): base(@"Data Source=(localdb)\MSSQLLocalDB;Initial 
            Catalog=Cantina;Integrated Security=True;Connect 
            Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=R
            eadWrite;MultiSubnetFailover=False")
        { }
        
        public DbSet<Produto> Produtos { get; set; }

    }
}
