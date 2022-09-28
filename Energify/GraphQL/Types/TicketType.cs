using Energify.Data.Entity;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energify.GraphQL.Types
{
    public class TicketType: ObjectGraphType<TicketEntity>
    {
        public TicketType()
        {
            Field(t => t.TicketId);
            Field(t => t.Email);
            Field(t => t.Category);
            Field(t => t.Description);
            Field(t => t.Status);
           
        }
    }
}
