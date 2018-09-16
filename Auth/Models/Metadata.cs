using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auth.Models
{
    public class PersonMetadata
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public short? SematId { get; set; }
        public virtual Semat Semat { get; set; }
    }

    public class SematMetadata
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }

}