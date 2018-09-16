using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auth.ViewModel
{
    public class PersonSematViewModel
    {
        public short Id { get; set; }

        public string Name { get; set; }

        public string Tel { get; set; }

        public IEnumerable<Semat> Semat { get; set; }

        public short? SematId { get; set; }

    }
}