using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGroup
{
    public abstract class ChatUser
    {
        public string Name;
        public abstract void ReceiveNotification(object source, ChatEventArgs args);
        
        public ChatUser(string Name)
        {
            this.Name = Name;
        }
    }
}
