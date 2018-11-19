using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternDemo
{
    class Football : Game
    {
        public override void Initialize()
        {
            Console.WriteLine("Football game inistialize!");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Football game started!");
        }

        public override void EndPlay()
        {
            Console.WriteLine("Football game finished!");
        }
    }
}
