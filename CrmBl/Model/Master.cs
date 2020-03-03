using System.Collections.Generic;

namespace CrmBl.Model
{
    public class Master
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public virtual ICollection<ServiceType> ServiceTypes { get; set; }

        public virtual ICollection<ServiceKind> ServiceKinds { get; set; }
        public string Description { get; set; }





        public Master()
        {
            ServiceTypes = new List<ServiceType>();
            ServiceKinds = new List<ServiceKind>();
        }
    }
}
