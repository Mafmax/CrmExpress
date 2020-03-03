using System.Collections.Generic;

namespace CrmBl.Model
{
    public class ServiceKind
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Master> Masters { get; set; }
        public ServiceType ServiceTypeId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }

        public ServiceKind()
        {
            Masters = new List<Master>();

        }

    }
}