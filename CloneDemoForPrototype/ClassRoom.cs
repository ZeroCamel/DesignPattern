using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneDemoForPrototype
{
    class ClassRoom : IDeepCopy, IShallowCopy
    {
        public int RoomID = 1;
        public string RoomName = "Room1";

        public override string ToString()
        {
            return "RoomId=" + RoomID + "\tRoomName=" + RoomName;
        }
        public object DeepCopy()
        {
            ClassRoom r = new ClassRoom();
            r.RoomID = this.RoomID;
            r.RoomName = this.RoomName;
            return r;
        }

        public object ShallowCopy()
        {
            //直接使用内置的浅COPY方法返回
            return this.MemberwiseClone();
        }
    }
}
