using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    /// <summary>
    /// 状态-抽象接口
    /// </summary>
    interface State
    {
        void doAction(Context context);
    }
}
