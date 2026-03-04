using Microsoft.EntityFrameworkCore;
using BizSecureDemo_22180011.Models;
using System.Collections.Generic;


 namespace BizSecureDemo_22180011.Data; 
    public class AppDbContext : DbContext
    {
        public DbSet<AppUser> Users => Set<AppUser>();
        public DbSet<Order> Orders => Set<Order>();
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
