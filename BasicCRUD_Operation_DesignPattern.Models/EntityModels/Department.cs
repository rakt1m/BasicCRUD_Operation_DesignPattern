using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCRUD_Operation_DesignPattern.Models.EntityModels
{
   public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<StudentInfo> StudentInfos { get; set; }
    }
}
