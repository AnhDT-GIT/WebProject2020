using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProject01.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string ProdName { get; set; }

        [Required]
        public string ProdImg { get; set; }

        [Required]
        public string ProdDes { get; set; }

        [Required]
        public string ProdPrice { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}