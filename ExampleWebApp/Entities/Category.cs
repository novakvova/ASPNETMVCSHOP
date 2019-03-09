using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExampleWebApp.Entities
{ 
    [Table("tblCategories")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(256)]
        public string Name { get; set; }
        [Required, StringLength(150)]
        public string Photo { get; set; }

    }
}