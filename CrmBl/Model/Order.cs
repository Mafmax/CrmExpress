using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBl.Model
{
    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public ICollection<ServiceKind> ServiceKinds { get; set; }

        public decimal AllPrice { get; set; }
        public ICollection<Master> PreferMasters { get; set; }

        // Предпочитаемая дата исполнения заявки.
        public ICollection<DateTime> PreferDates { get; set; }

        // Дата оформления заявки.
        public DateTime Date { get; set; }


        public Order()
        {
            ServiceKinds = new List<ServiceKind>();
            PreferDates = new List<DateTime>();
            PreferMasters = new List<Master>();
        }

    }
}
