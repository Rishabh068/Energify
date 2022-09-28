using Energify.Data.Entity;
using Energify.GraphQL.Types;
using Energify.Repository;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energify.GraphQL
{
    public class EnergifyMutation: ObjectGraphType
    {
        public EnergifyMutation(UserRepository s,ProductRepository p)
        {
            Field<UserType>("Registeruser", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "email" },
                                                                           new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "pass" },
                                                                           new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "Name" },
                                                                           new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "Address" },
                                                                           new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "rolecode" }
                                                                           ), resolve: context =>
                                                                      {
                                                                          var email = context.GetArgument<string>("email");
                                                                          var pass = context.GetArgument<string>("pass");
                                                                          var Name = context.GetArgument<string>("Name");
                                                                          var addr= context.GetArgument<string>("Address");
                                                                          var rolecode = context.GetArgument<int>("rolecode");
                                                                          return s.RegisterUser(email, pass, Name, addr, rolecode);
                                                                      });

            Field<ProductType>(
            "addproduct",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ProductInputType>> { Name = "newproduct" }),
            resolve: context =>
            {
                var newprod= context.GetArgument<ProductEntity>("newproduct");
                return p.Addproduct(newprod.Name, newprod.Price, newprod.Quantity, newprod.Status, newprod.Measurement, newprod.Description, newprod.CategoryName, newprod.Image);

            });
            Field<ProductType>(
           "removeproduct",
           arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "proid" }),
           resolve: context =>
           {
               var index = context.GetArgument<int>("proid");
               return p.RemoveProduct(index);
        

           });

        }
    }
}
