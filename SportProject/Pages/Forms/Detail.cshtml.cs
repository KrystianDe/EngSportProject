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
    public class DetailModel : PageModel
    {
        private readonly IFormData formData;
        [TempData]
        public string Message { get; set; }
        [BindProperty]
        public Form Form { get; set; }
        public DateTime dateTime { get; set; }

        public Boolean flag { get; set; }

        public DetailModel(IFormData formData)
        {
            this.formData = formData;
        }
        public IActionResult OnGet(int formId)
        {
            this.Form = formData.GetById(formId);
            this.dateTime = DateTime.Today;
            this.flag = true;
            return Page();
        }

        public IActionResult OnPost()
        {
           string buttonClicked = Request.Form["SubmitButton"];

            if(buttonClicked == "Accept")
            {
                Form.Accepted = true;
            }
            else if(buttonClicked == "Decline")
            {
                Form.Accepted = false;
            }
            
           
           
                
           formData.Update(Form);
            //Form = formData.Update(Form);
            formData.Commit();
            //TempData["Message"] = "Form Sent";
            return RedirectToPage("./List");
        }
    }
}