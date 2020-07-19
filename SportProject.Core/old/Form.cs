using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportProject.Core
{
    public class Form 
    {
        public int Id { get; set; }

        [Required, StringLength(255)]
        public String Name { get; set; }
        [Required, StringLength(555)]
        public String Description { get; set; }
       
        public DateTime Date { get; set; }

        public Boolean Accepted { get; set; }
    }
}
