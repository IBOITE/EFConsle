using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFConsle
{
    //bu kullandim table isimini degistirmek icin
    [Table("baskaIsim")]
    public class Post
    {
        //spl'e bir aciklama ekliyor
        [Comment("the id of the post")]
        public int Id { get; set; }
        //bu prop isimi degistirmek icin
        
        [Column("VlauePost")]
        public String Value { get; set; }
        //bu length tanimlamak icin
        [MaxLength(200)]
        public string nama { get; set; }
    }
}
