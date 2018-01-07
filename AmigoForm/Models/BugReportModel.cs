using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmigoForm.Models
{
    public class BugReportModel
    {
        public int ID { get; set; }

        [StringLength(60,MinimumLength = 3)]
        [Required(ErrorMessage ="Your name is required")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage ="Your email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A description of the bug is required")]
        public string BugDesc { get; set; }
    
        [Required(ErrorMessage = "A bug category is required")]
        public string BugType { get; set; }
    }
}

