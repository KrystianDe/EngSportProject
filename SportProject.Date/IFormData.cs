//using SportProject.Core;
//using SportProject.Core;
using SportProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace SportProject.Data
{
    public interface IFormData
    {
        IEnumerable<Form> GetAll();
        Form GetById(int id);
        Form Add(Form newForm);
        int Commit();
        Form Update(Form updateForm);
        Form Delete(int id);
    }
}
