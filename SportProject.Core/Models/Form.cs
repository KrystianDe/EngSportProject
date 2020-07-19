using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportProject.Core.Models
{
    public partial class Form
    {
        
        public int IdForm { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public bool? Accepted { get; set; }
        public int IdStudent { get; set; }

        public virtual Student IdStudentNavigation { get; set; }
    }
}
