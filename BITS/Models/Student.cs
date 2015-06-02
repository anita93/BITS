using System;
using System.Data.Entity;

namespace BITS.Models
{
   
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Branch { get; set; }
        public decimal CPI { get; set; }
    }
    public class StudentsDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
