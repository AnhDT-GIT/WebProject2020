using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebProject01.Models;

namespace WebProject01.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProdName { get; set; }

        [Required]
        public string ProdDes { get; set; }

        [Required]
        public string ProdImg { get; set; }

        [Required]
        public string ProdPrice { get; set; }

        public int Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Heading { get; set; }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }
    }
}