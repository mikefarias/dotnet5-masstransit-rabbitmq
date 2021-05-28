using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet5_masstransit_rabbitmq
{
    public class AppplicationContext: DbContext
    {

        public DbSet<Proposta> Proposta { get; set; }

    }
}
