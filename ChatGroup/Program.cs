using System;

namespace ChatGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var ActiveUser = new ActiveUser("John");
            var Group = new ChatGroup();
            Group.AddMember(ActiveUser);
            
            ActiveUser.SendMessagge("Welcome everbody!");

            var Observer = new Observer("Mike");
            Group.AddMember(Observer);
            var Observer2 = new Observer("Meli");
            Group.AddMember(Observer2);
            var Observer3 = new Observer("Jake");
            Group.AddMember(Observer3);

            var ActiveUser2 = new ActiveUser("Vanessa");
            Group.AddMember(ActiveUser2);

            Group.CreateNotification("HI");
            Group.CreateNotification("Welcome to the group!");
        }
    }


    // Am folosit Observer Design Pattern.
}
