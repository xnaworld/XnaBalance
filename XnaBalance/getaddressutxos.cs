using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XnaBalance
{
    public class getaddressutxos
    {
        public class Rootobject
        {
            public Result[] result { get; set; }
            public object error { get; set; }
            public int id { get; set; }
        }

        public class Result
        {
            public string address { get; set; }
            public string assetName { get; set; }
            public string txid { get; set; }
            public int outputIndex { get; set; }
            public string script { get; set; }
            public long satoshis { get; set; }
            public int height { get; set; }
        }
    }
}
