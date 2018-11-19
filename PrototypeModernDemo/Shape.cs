using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternDemo
{
    [Serializable]
    public abstract class Shape : System.Object, ICloneable
    {
        private string Id;
        protected string type;

        public abstract void draw();

        public string getType()
        {
            return type;
        }

        public string getId()
        {
            return Id;
        }

        public void setId(string Id)
        {
            this.Id = Id;
        }

        public object Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Seek(0, SeekOrigin.Begin);
            return (Shape)bf.Deserialize(ms);
        }
    }
}
