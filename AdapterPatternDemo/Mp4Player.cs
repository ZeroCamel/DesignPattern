using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo
{
    class Mp4Player : AdvancedMediaPlayer
    {
        public void playVlc(string fileName)
        {

        }

        public void playMp4(string fileName)
        {
            Console.WriteLine("Playing Mp4 file.name:" + fileName);
        }
    }
}
