using System;
using System.Collections.Generic;
using System.Text;
using BasicCRUD_Operation_DesignPattern.Models.EntityModels;
using BasicCRUD_Operation_DesignPattern.Repositories.Contracts;

namespace BasicCRUD_Operation_DesignPattern.Repositories.Repositories
{
   public class StudentInfoRepository :Repository<StudentInfo>,IStudentInfoRepository
    {
    }
}
