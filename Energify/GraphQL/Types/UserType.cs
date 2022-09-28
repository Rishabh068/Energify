using Energify.Data.Entity;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energify.GraphQL.Types
{
    public class UserType: ObjectGraphType<UserEntity>
    {
        public UserType()
        {

            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.rolecode);
            Field(t => t.Email);
            Field(t => t.Password);
            Field(t => t.Address);
        }
    }
}
