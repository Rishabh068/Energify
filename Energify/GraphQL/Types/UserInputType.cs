using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energify.GraphQL.Types
{
    public class UserInputType:InputObjectGraphType
    {
        public UserInputType()
        {
            Name = "Userinput";
            Field<NonNullGraphType<StringGraphType>>("email");
            Field<NonNullGraphType<StringGraphType>>("password");
            Field<NonNullGraphType<StringGraphType>>("Address");
            Field<NonNullGraphType<IntGraphType>>("rolecode");
             Field<NonNullGraphType<StringGraphType>>("Name");
          
        }
    }
}
