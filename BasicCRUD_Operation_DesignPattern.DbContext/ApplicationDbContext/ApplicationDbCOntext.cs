using System;
using System.Collections.Generic;
using System.Text;
using BasicCRUD_Operation_DesignPattern.Models.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace BasicCRUD_Operation_DesignPattern.DbContext.ApplicationDbCOntext
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext()
        {
            
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=RAKTIM-PC;Database=BasicCRUD;Trusted_Connection=true");

        }

        public virtual DbSet<StudentInfo> StudentInfos { get; set; }
        public  DbSet<Department> Departments { get; set; }

    }
}
