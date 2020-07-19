using Microsoft.EntityFrameworkCore;

using SportProject.Core.Models;

using System.Collections.Generic;
using System.Linq;

namespace SportProject.Data
{
    public class SqlFormData : IFormData
    {
        private readonly masterContext db;
        public SqlFormData(masterContext db)
        {
            this.db = db;
        }
        public Form Add(Form newForm)
        {
          
            db.Add(newForm);
      
            return newForm;
        }

        public int Commit()
        {
            
            return db.SaveChanges();
        }

        public Form Delete(int id)
        {
            var form = GetById(id);
            if(form != null)
            {
                db.Form.Remove(form);
            }
            return form;
        }

        public IEnumerable<Form> GetAll()
        {
                var query = from f in db.Form
                            select f;
                return query;
  
        }

        public Form GetById(int id)
        {
            
            return db.Form.Find(id); //.Find(id);
        }

        public Form Update(Form updateForm)
        {
            
           db.Form.Update(updateForm);
           
            return updateForm;
        }
    }
}
