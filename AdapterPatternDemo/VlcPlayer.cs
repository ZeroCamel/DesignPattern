using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo
{
    class VlcPlayer : AdvancedMediaPlayer
    {
        public void playVlc(string fileName)
        {
            Console.WriteLine("Playing Vlc file.name:" + fileName);
        }

        public void playMp4(string fileName)
        {
            
        }
    }
}
