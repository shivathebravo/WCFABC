using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    class MyService:IMyService
    {
        public string GetData()
        {
            return "Hello WCF";
        }
    }
}
