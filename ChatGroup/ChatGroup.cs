using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGroup
{
    public class ChatGroup
    {
        private List<ChatUser> membersList = new List<ChatUser>();

        public event EventHandler<ChatEventArgs> notify;

        public void CreateNotification(string text)
        {
            notify(this, new ChatEventArgs(new ChatNotification(text)));
        }

        public void AddMember(ChatUser chatUser)
        {
            int counter = 0;
            
            if (membersList.Count < 10)
            {
                foreach (ChatUser user in membersList)
                {
                    if (user.GetType() == typeof(Observer))
                    {
                        counter++;
                    }
                }

                if (counter == 2 && chatUser.GetType() == typeof(Observer))
                {
                    Console.WriteLine("ERROR: You already have 2 Observers");
                }
                else
                {
                    membersList.Add(chatUser);
                    notify += chatUser.ReceiveNotification;
                }
            }
        }
    }
}
