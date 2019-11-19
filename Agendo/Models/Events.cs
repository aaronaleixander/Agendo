using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agendo.Models
{
    public class Events
    {
        
        public int EventID { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public Boolean ISFullDay { get; set; }
    }
}
