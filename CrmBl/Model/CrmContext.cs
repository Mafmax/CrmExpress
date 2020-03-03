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
    }
}
