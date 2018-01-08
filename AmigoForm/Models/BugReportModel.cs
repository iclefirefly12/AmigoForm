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

        [Display(Prompt = "Your Name")]
        public string CustomerName { get; set; }

        [Display(Prompt = "Your Email")]
        public string Email { get; set; }

        [Display(Prompt = "Description of the Bug")]
        public string BugDesc { get; set; }

        public string BugType { get; set; }

        public string CustomerType { get; set; }
    }
}

