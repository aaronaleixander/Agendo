using Agendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agendo.Data
{
    public static class EventsDb
    {
        public static async Task<Events> Add(Events addEvent, AgendoContext context)
        {
            await context.AddAsync(addEvent);
            await context.SaveChangesAsync();
            return addEvent;
        }
    }
}
