using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using FreeLancers4.Areas.Identity.Data;


namespace FreeLancers4.Models
{
    public class Work
    {

        [Display(Name = "Project Number")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter a project name")]
        [DataType(DataType.Text)]
        [Display(Name = "Title")]
        
        public string ProjectTitle { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Posted Date")]
        public DateTime PostDate { get; set; }

        [Required(ErrorMessage = "Enter a consice project description")]
        [DataType(DataType.Text)]
        [Display(Name = "Project description")]
        [StringLength(500, ErrorMessage = "Please write a decription of the project with as many details as you can manage", MinimumLength = 10)]
        public string Description { get; set; }


        [Required(ErrorMessage = "Enter the skills you require")]
        [DataType(DataType.Text)]
        [Display(Name = "Skills Required")]
        public string Skills { get; set; }

        [Required(ErrorMessage = "What is the cost?")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [Range(1,100000, ErrorMessage = "The price cannot be more than 100,000 KES!")]
        [Display(Name = "Project Cost")]
        public decimal Price { get; set; }
        
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "When is the project due?")]
        [Display(Name = "Deadline")]
        public DateTime DueDate { get; set; }//when is the product needed
        
        [Display(Name ="Contact Email")]
        [EmailAddress]
        [Required(ErrorMessage = "Please add an email you check frequently!")]
        public string ContactEmail { get; set; }

        public string OwnedBy { get; set; }

        [ForeignKey("OwnedBy")]
        public FreeLancers4User Owner { get; set; }//which client

        public string AssignedTo { get; set; }

        [ForeignKey("AssignedTo")]
        public FreeLancers4User Assigned { get; set; }

        [DataType(DataType.Date)]
        public DateTime CompleteDate { get; set; }

        [DataType(DataType.Text)]
        public string WorkStatus { get; set; }

    }
}
