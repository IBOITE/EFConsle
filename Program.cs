using System;

namespace EFConsle
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            var employee = new Employee
            {
                Name="ibo"
            };
            db.Employees.Add(employee);
            db.SaveChanges();
        }
    }
}
