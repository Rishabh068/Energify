using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energify.Data.Entity
{
    public class ProductEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public int Price { get; set; }
        public string Status { get; set; }
        public int Quantity { set; get; }
        public string Measurement { set; get; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string Image { get; set; }
    }
}
