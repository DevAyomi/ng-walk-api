using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api.Models.Domain;

namespace api.Data
{
    public class NgWalksDBContext:DbContext
    {
        public NgWalksDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}