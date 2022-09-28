using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energify.GraphQL.Types
{
    public class ProductInputType: InputObjectGraphType
    {
        public ProductInputType()
        {
            Name = "Productinput";
            Field<NonNullGraphType<StringGraphType>>("Name");
            Field<NonNullGraphType<IntGraphType>>("Price");
            Field<NonNullGraphType<IntGraphType>>("Quantity");
            Field<NonNullGraphType<StringGraphType>>("Status");
            Field<NonNullGraphType<StringGraphType>>("Description");
            Field<NonNullGraphType<StringGraphType>>("CategoryName");
            Field<NonNullGraphType<StringGraphType>>("Image");
            Field<NonNullGraphType<StringGraphType>>("Measurement");
        }
    }
}
