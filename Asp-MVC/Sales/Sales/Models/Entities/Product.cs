using System;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int CategoryId { get; set; }  //ürünün kategorisi ne onu aldık
        public Category Category { get; set; }

    }
}
