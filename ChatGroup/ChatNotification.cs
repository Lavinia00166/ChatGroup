using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGroup
{
    public class ChatNotification
    {
        private string Notification;

        public ChatNotification(string Notification)
        {
            this.Notification = Notification;
        }

        public string getNotification() => Notification;
      
    }
}
