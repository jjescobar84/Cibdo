using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cibdo.Models
{
    public class CibdoContext: DbContext
    {
        public CibdoContext() 
           : base("DefaultConnection")
        { }

        public DbSet<Reminder> Reminders { get; set; }

        public DbSet<ReminderType> ReminderTypes { get; set; }

    }
}