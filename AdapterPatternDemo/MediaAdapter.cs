using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo
{
    class MediaAdapter : MediaPlayer
    {
        //依赖注入-属性注入
        AdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            //简单工厂-动态创建类的实例
            if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                advancedMediaPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                advancedMediaPlayer = new Mp4Player();
            }
        }
        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                advancedMediaPlayer.playVlc(fileName);
            }
            else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                advancedMediaPlayer.playMp4(fileName);
            }
        }
    }
}
