using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energify.GraphQL.Types
{
    public class TicketInputType: InputObjectGraphType
    {
        public TicketInputType()
        {

            Name = "Ticketinput";
            Field<NonNullGraphType<StringGraphType>>("TicketId");
            Field<NonNullGraphType<IntGraphType>>("Category");
            Field<NonNullGraphType<IntGraphType>>("Description");
           
        }
    }
}
