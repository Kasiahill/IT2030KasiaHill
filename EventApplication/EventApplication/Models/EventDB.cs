using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class EventDB : DbContext
    {
        public EventDB() : base("name=EventDB")
        {
        }

        public System.Data.Entity.DbSet<EventApplication.Models.Event> Events { get; set; }

        public System.Data.Entity.DbSet<EventApplication.Models.EventType> EventTypes { get; set; }

        public System.Data.Entity.DbSet<EventApplication.Models.Cart> Carts { get; set; }
    }
}
}