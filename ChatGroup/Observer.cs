using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGroup
{
    class Observer : ChatUser
    {
        public Observer(string Name): base(Name)
        {

        }
        public override void ReceiveNotification(object source, ChatEventArgs args)
        {
            Console.WriteLine($"{Name} has been notified for {args.ChatNotification.getNotification()}");
        }
    }
}
