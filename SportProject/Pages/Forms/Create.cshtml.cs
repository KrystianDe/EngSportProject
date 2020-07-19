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
    public class CreateModel : PageModel
    {
        private readonly IFormData formData;
        [BindProperty]
        public Form Form { get; set; }
        public DateTime dateTime { get; set; }

        public CreateModel(IFormData formData)
        {
            this.formData = formData;
            this.dateTime = DateTime.Today;
        }
        public void OnGet()
        {
            //Form = formData.GetById(formId);
            //if(Form == null)
            //{
            //    return RedirectToPage("./NotFound");
            //}
            //return Page();
           Form = new Form();
        }

        public IActionResult OnPost()
        {
           
            formData.Add(Form);
            //Form = formData.Update(Form);
            formData.Commit();
            TempData["Message"] = "Form Sent";
            return RedirectToPage("./List");
        }
    }
}