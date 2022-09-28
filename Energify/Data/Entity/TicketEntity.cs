using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Energify.Data.Entity
{
    public class TicketEntity
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        [Key]
        public string TicketId { get; set; }
    }
}
