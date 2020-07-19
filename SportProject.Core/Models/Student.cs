using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportProject.Core.Models
{
    public partial class Student
    {
        public Student()
        {
            Form = new HashSet<Form>();
        }

        
        public int IdStudent { get; set; }
        public string Index { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Form> Form { get; set; }
    }
}
