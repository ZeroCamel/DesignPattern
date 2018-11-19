using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservePatternDemo
{
    public class Subject
    {
        //存储观察者对象
        private List<Observer> observers = new List<Observer>();

        private int state;

        public void SetState(int state)
        {
            this.state = state;
        }

        public int GetState()
        {
            return state;
        }

        //关联相关类
        public void  Attach(Observer observer)
        {
            observers.Add(observer);
        }

        //通知其他类并更新
        public void nofityAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.update();
            }
        }
    }
}
