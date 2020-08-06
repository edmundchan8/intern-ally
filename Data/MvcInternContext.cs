using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using intern_ally.Models;
using Microsoft.EntityFrameworkCore;

namespace intern_ally.Data
{
    public class MvcInternContext : DbContext
    {
        public MvcInternContext(DbContextOptions<MvcInternContext> options) : base(options)
        {
        }
        public DbSet<Intern> Intern { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        
    }
}
