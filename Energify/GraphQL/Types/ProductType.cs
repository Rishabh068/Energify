using Energify.Data.Entity;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energify.GraphQL.Types
{
    public class ProductType: ObjectGraphType<ProductEntity>
    {
        public ProductType()
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Price);
            Field(t => t.Quantity);
            Field(t => t.Status);
            Field(t => t.Description);
            Field(t => t.CategoryName);
            Field(t => t.Image);
            Field(t => t.Measurement);
        }
    }
}
