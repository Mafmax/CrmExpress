using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBl.Model
{
    public class ProcessedCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public ICollection<ServiceKind> ServiceKinds { get; set; }
        public decimal Cash { get; set; }

        public ICollection<Master> Masters { get; set; }

        public DateTime Date { get; set; }
        public ProcessedCustomer()
        {
            ServiceKinds = new List<ServiceKind>();
            Masters = new List<Master>();
        }

    }
}
