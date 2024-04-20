using _3_Solid_L_Problem.Utils.Notification.Base;

namespace _3_Solid_L_Problem.Utils.Notification
{
    public class NotificationService : INotificationService
    {
        private readonly IGeneralNotification _generalNotification;

        public NotificationService(IGeneralNotification generalNotification)
        {
            _generalNotification = generalNotification;
        }

        public bool SendNotification(string message)
        {
            _generalNotification.SendNotification(message);
            return true;
        }
    }
}
