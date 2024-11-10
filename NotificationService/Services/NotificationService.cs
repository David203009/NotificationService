using NotificationService.Data;
using NotificationService.Models;
using System.Threading.Tasks;


namespace NotificationService.Services
{
    public class NotificationService
    {

        private readonly NotificationDbContext _context;

        public NotificationService(NotificationDbContext context)
        {
            _context = context;
        }

        public async Task AddNotification(NotificationModel notification)
        {
            _context.Notifications.Add(notification);
            await _context.SaveChangesAsync();
        }

    }
}
