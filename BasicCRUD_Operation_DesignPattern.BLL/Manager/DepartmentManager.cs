using System;
using System.Collections.Generic;
using System.Text;
using BasicCRUD_Operation_DesignPattern.BLL.Contracts;
using BasicCRUD_Operation_DesignPattern.Models.EntityModels;
using BasicCRUD_Operation_DesignPattern.Repositories.Contracts;

namespace BasicCRUD_Operation_DesignPattern.BLL.Manager
{
  public  class DepartmentManager: Manager<Department>,IDepartmentManager
    {
        public DepartmentManager(IDepartmentRepository repository) : base(repository)
        {
            
        }
    }
}
