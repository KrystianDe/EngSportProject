using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportProject.Core.Models;
using SportProject.Data;


namespace SportProject.Pages.Forms
{
    public class ListModel : PageModel
    {
        private readonly IFormData formData;

        public IEnumerable<Form> Forms { get; set; }
        public ListModel(IFormData formData)
        {
            this.formData = formData;
        }
        public void OnGet()
        {
            
                Forms = formData.GetAll();
        }
    }
}