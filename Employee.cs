using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFConsle
{
    public class Employee
    {
        public int Id { get; set; }
        //bu datatype degistirmek icin
        [Column(TypeName = "varchar(200)")]
        public string Name { get; set; }
        public int sayici { get; set; }
        public DateTime tarih { get; set; }
    }
}
