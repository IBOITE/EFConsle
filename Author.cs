using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFConsle
{
    public class Author
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public String FirstName { get; set; }
        [Required, MaxLength(50)]
        public String LastName { get; set; }

        public String FirstVeLast { get; set; }
    }
}
