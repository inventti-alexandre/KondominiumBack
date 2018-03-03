using System.Collections.Generic;

namespace Kondominium.Domain.Notification
{
    public class Notifications
    {
        private List<string> notifications;

        public void AddNotification(string message)
        {
            Initialize();
            notifications.Add(message);
        }

        public List<string> GetNotifications()
        {
            Initialize();
            return notifications;
        }

        private void Initialize()
        {
            if (notifications == null)
                notifications = new List<string>();
        }
    }
}
