using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo
{
    public class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;
        public void Play(string audioType, string fileName)
        {
            //播放音乐文件的内置支持
            if (audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Playing Mp3 file.name:" + fileName);
            }
            //适配器提供播放其他文件的支持
            else if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase) || audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            //格式不支持
            else
            {
                Console.WriteLine("Invalid media." + audioType + " format not supported!");
            }
        }
    }
}
