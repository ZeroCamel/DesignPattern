using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternDemo
{
    //用户类
    class User
    {
        private string name;

        public User(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void ShowMessage(string message)
        {
            ChatRoom.ShowMessage(this,message);
        }
    }
}
