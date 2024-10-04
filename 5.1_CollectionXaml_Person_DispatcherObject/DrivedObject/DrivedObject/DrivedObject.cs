using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Diagnostics;

namespace DrivedObject1
{
    public class DrivedObject : DispatcherObject
    {

        public void DoSomething()
        {
            // UI スレッドからのアクセスかチェックする
            this.VerifyAccess();
            Debug.WriteLine("DoSomething");

        }

    }
}
