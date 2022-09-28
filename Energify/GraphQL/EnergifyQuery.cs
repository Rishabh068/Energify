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
    public class EnergifyQuery:ObjectGraphType
    {
        public EnergifyQuery(UserRepository s,ProductRepository p,TicketRepository t)
        {
            Field<UserType>("loginuser", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "email" },
                                                                       new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "pass" }), resolve: context =>
            {
                var email = context.GetArgument<string>("email");
                var pass = context.GetArgument<string>("pass");
                return s.LoginUser(email,pass);
            });
            Field<ListGraphType<ProductType>>(
                "getproducts",
                resolve: context => p.GetProducts()
                );
            Field<ListGraphType<TicketType>>(
               "gettickets",
               resolve: context => t.GetTickets()
               );

        }
    }
}
