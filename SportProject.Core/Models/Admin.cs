using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportProject.Core.Models
{
    public partial class Admin
    {
       
        public int IdAdmin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
