using System.Collections.Generic;

namespace Kondominium.Domain.Notification
{
    public class Notifications
    {
        private List<string> _notifications;

        public void AddNotification(string message)
        {
            Initialize();
            _notifications.Add(message);
        }

        public void AddNotification(List<string> notifications)
        {
            Initialize();
            _notifications.AddRange(notifications);
        }

        public List<string> GetNotifications()
        {
            Initialize();
            return _notifications;
        }

        private void Initialize()
        {
            if (_notifications == null)
                _notifications = new List<string>();
        }

        public bool IsValid()
        {
            return _notifications.Count == 0;
        }
    }
}
