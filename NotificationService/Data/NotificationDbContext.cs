using NotificationService.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NotificationService.Data
{
    public class NotificationDbContext : DbContext
    {

        public NotificationDbContext(DbContextOptions<NotificationDbContext> options) : base(options) { }

        public DbSet<NotificationModel> Notifications { get; set; }

    }
}
