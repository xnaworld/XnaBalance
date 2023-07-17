using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XnaBalance
{
    public class GetBalance
    {
        public class Rootobject
        {
            public Result result { get; set; }
            public object error { get; set; }
            public int id { get; set; }
        }

        public class Result
        {
            public long balance { get; set; }
            public long received { get; set; }
        }
    }
}
