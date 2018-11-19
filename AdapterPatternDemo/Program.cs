using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo
{
    class Program
    {
        //名称：适配器模式
        //分类：结构型
        //目的：不兼容接口之间的桥梁，接口功能的组合（读卡器-内存卡与笔记本之间的桥梁）
        //优点:增加类的透明度、灵活、复用
        //缺点：过多使用适配器系统零乱
        //场景：修改正在运行的系统接口
        //应用：c# dataAdapter

        //适配器桥接外观模式联系
        //1.
        static void Main(string[] args)
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.Play("mp3","beyond the horizon.mp3");
            audioPlayer.Play("mp4","along.mp4");
            audioPlayer.Play("vlc","vlc.vlc");
            audioPlayer.Play("avi","avi.avi");

            Console.Read();
        }
    }
}
