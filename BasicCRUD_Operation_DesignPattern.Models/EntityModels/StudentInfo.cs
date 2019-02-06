using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCRUD_Operation_DesignPattern.Models.EntityModels
{
    public class StudentInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }

        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
