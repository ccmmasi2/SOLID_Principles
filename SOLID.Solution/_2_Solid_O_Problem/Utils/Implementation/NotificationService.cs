using _2_Solid_O_Problem.Models;
using _2_Solid_O_Problem.Utils.Interface;

namespace _2_Solid_O_Problem.Utils.Implementation
{
    public class NotificationService : INotificationService
    {
        /// <summary>
        /// The problem in this project is that NotificationService.SendNotification is a method that has a switch to iterate between different kind of notifications, for now has the possibility to send emails to Gmail and Hotmail, but if we need another notifications such as Personal notification, or using a broker, API, WCF or another kinds of notifications, we need to add other lines to add to the switch structure. 
        /// Here we could break Open-Closed Principle, it says if we need to add another feature - functionality to a class, we should'n modify the class, instead of this, we should add an interface with the new features and implementate this interface
        /// </summary>
        /// <param name="message"></param>
        /// <param name="notificationEnum"></param>
        /// <returns></returns>
        public bool SendNotification(string message, TypeNotificationEnums notificationEnum)
        {
            switch (notificationEnum)
            {
                case TypeNotificationEnums.HotmailEmail:
                    NotificationHotmail(message);
                    break;
                case TypeNotificationEnums.GmailEmail:
                    NotificationGmail(message);
                    break;
                default:
                    return false;
            }

            return true;
        }

        private void NotificationHotmail(string message)
        {
            throw new NotImplementedException();
        }

        private void NotificationGmail(string message)
        {
            throw new NotImplementedException();
        }
    }
}
