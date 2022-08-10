using System;
using Microsoft.EntityFrameworkCore;

namespace OnionStart.Persistance.Context
{
    public class ProniaDbContext:DbContext
    {
        public ProniaDbContext(DbContextOptions<ProniaDbContext>options):base(options)
        {

        }
    }
}

