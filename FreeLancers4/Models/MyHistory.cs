using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeLancers4.Models
{
    public class MyHistory
    {
        public int ID { get; set; }

        public string ProjectName { get; set; }

        public string Description { get; set; }

        public string Freelancer { get; set; }

        public int Rating { get; set; }

        public DateTime DeliveredOn { get; set; }
    }
}
