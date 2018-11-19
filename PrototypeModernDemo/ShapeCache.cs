using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternDemo
{
    public class ShapeCache
    {
        private static Hashtable hs = new Hashtable();
        public static Shape getShape(string shapId)
        {
            Shape cachedShape = hs[shapId] as Shape;
            return (Shape)cachedShape.Clone();
        }
        public static void loadCache()
        {
            Circle cl = new Circle();
            cl.setId("1");
            hs.Add(cl.getId(), cl);

            Square sq = new Square();
            sq.setId("2");
            hs.Add(sq.getId(), sq);

            Rectangle re = new Rectangle();
            re.setId("3");
            hs.Add(re.getId(), re);
        }
    }
}
