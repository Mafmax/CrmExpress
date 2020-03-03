using System.Collections.Generic;


namespace CrmBl.Model
{
    public class ServiceType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Master> Masters { get; set; }
        public virtual ICollection<ServiceKind> ServiceKinds { get; set; }


        public ServiceType()
        {
            Masters = new List<Master>();
            ServiceKinds = new List<ServiceKind>();
        }
    }
}
