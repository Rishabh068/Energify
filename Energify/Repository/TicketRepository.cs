using Energify.Data;
using Energify.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energify.Repository
{
    public class TicketRepository
    {
        public EnergifyDbContext _dbcontext;
        public TicketRepository(EnergifyDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IEnumerable<TicketEntity> GetTickets()
        {
            return _dbcontext.TicketList;
        }
        public TicketEntity AddTicket(string id,string category,string desc,string status="IN PROGRESS")
        {
            var add = new TicketEntity() { TicketId = id, Category = category, Description = desc, Status = status };
            _dbcontext.TicketList.Add(add);
            _dbcontext.SaveChanges();
            return add;
        }
        public TicketEntity SetStatus(string tickid)
        {
           var x = _dbcontext.TicketList.First(s => String.Equals(s.TicketId,tickid));
            x.Status = "Approved";
            _dbcontext.SaveChanges();
            return x;

        }
    }
}
