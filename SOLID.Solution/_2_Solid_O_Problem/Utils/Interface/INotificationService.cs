using _2_Solid_O_Problem.Models;

namespace _2_Solid_O_Problem.Utils.Interface
{
    public interface INotificationService
    {
        bool SendNotification(string message, TypeNotificationEnums notificationEnum);
    }
}
