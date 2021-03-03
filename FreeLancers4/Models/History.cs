using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FreeLancers4.Models
{
    public class History
    {
        public int ID { get; set; }

        [DataType(DataType.Custom)]
        [Range(1,5,ErrorMessage = "Please enter a number betwen 1 and 5")]
        [Required]
        public int Rating { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }
        
        public int ProjectID { get; set; }

        // The project to check history on
        [Required]
        [ForeignKey("ProjectID")]
        public Work Project { get; set; }

    }
}
