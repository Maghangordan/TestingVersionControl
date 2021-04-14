using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using tsport.Models;

namespace tsport.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<tsport.Models.Order> Order { get; set; }
        public DbSet<tsport.Models.Transporter> Transporter { get; set; }
    }
}
