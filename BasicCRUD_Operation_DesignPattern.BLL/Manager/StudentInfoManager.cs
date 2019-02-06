using System;
using System.Collections.Generic;
using System.Text;
using BasicCRUD_Operation_DesignPattern.BLL.Contracts;
using BasicCRUD_Operation_DesignPattern.Models.EntityModels;
using BasicCRUD_Operation_DesignPattern.Repositories.Contracts;

namespace BasicCRUD_Operation_DesignPattern.BLL.Manager
{
    public class StudentInfoManager:Manager<StudentInfo>,IStudentInfoManager
    {
        public  StudentInfoManager(IStudentInfoRepository repository) : base(repository) { }
    }
}
