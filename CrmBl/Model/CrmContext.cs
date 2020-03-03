using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBl.Model
{
    class CrmContext : DbContext
    {
        public CrmContext() : base("CrmConnection") { }


        public DbSet<Master> Masters { get; set; }
        public DbSet<ServiceType>  ServiceTypes { get; set; }
        public DbSet<ServiceKind> ServiceKinds { get; set; }
        public DbSet<ProcessedCustomer> ProcessedCustomers  { get; set; }
        public DbSet<Order> Orders  { get; set; }
        public DbSet<Review> Reviews  { get; set; }




    }
}
