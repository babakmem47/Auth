using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Auth.Models
{
    [MetadataType(typeof(PersonMetadata))]
    public partial class Person
    {

    }
    
    [MetadataType(typeof(SematMetadata))]
    public partial class Semat
    {
        
    }

}