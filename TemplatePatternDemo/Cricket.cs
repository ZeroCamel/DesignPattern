using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternDemo
{
    class Cricket : Game
    {

        public override void Initialize()
        {
            Console.WriteLine("Criket game finished!");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Criket game Started.Enjoy the game!");
        }

        public override void EndPlay()
        {
            Console.WriteLine("Cricket game finished!");
        }
    }
}
