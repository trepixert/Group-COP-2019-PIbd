using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class AbstractDBContext : DbContext
    {
        public AbstractDBContext() : base("StudentAccounting")
        {           
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied = SqlProviderServices.Instance;
        }

        public virtual DbSet<Student> Students { get; set; }
    }
}

