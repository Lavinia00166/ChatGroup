using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGroup
{
    class ActiveUser : ChatUser
    {
        public event EventHandler<ChatEventArgs> send;

        public ActiveUser(string Name): base(Name)
        {

        }
        public override void ReceiveNotification(object source, ChatEventArgs args)
        {
            Console.WriteLine($"{Name} has been notified for {args.ChatNotification.getNotification()}");
        }

        public void SendMessagge(string Message)
        {
            if (send != null) 
            {
                send(this, new ChatEventArgs(new ChatNotification(Message)));
            }
        }
    }
}
