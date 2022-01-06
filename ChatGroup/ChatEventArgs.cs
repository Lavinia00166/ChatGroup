using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGroup
{
    public class ChatEventArgs
    {
        public ChatEventArgs(ChatNotification chatNotification)
        {
            ChatNotification = chatNotification;
        }

        public ChatNotification ChatNotification { get; private set; }

    }
}
