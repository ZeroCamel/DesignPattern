using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo
{
    interface MediaPlayer
    {
        void Play(String audioType, string fileName);
    }
}
