using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternDemo
{
    class ChatRoom
    {
        public static void ShowMessage(User user, string message)
        {
            //Console.WriteLine(System.DateTime.Now.ToString("f/y/m/d") + " [ " + user.GetName() + " ]: " + message);
            //Console.WriteLine(System.DateTime.Now.ToString("t") + " [ " + user.GetName() + " ]: " + message);
            //Console.WriteLine(System.DateTime.Now.ToLongDateString() + " [ " + user.GetName() + " ]: " + message);
            //Console.WriteLine(System.DateTime.Now.ToShortDateString() + " [ " + user.GetName() + " ]: " + message);
           //Console.WriteLine(System.DateTime.Now.ToShortTimeString() + " [ " + user.GetName() + " ]: " + message);
            Console.WriteLine(System.DateTime.Now.ToLongTimeString()+ " [ " + user.GetName() + " ]: " + message);
        }
    }
}
