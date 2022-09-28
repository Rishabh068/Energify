using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energify.GraphQL
{
    public class EnergifySchema:Schema
    {
        public EnergifySchema(IServiceProvider resolver):base(resolver)
        {
            Query = (IObjectGraphType)resolver.GetService(typeof(EnergifyQuery));
            Mutation = (IObjectGraphType)resolver.GetService(typeof(EnergifyMutation));
        }
    }
}
