using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProject01.Models;

namespace WebProject01.ViewModels
{
    public class GetView
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}