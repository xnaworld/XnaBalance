using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XnaBalance
{
    public class getrawtransaction
    {
        public class Rootobject
        {
            public Result result { get; set; }
            public object error { get; set; }
            public int id { get; set; }
        }

        public class Result
        {
            public string txid { get; set; }
            public string hash { get; set; }
            public int version { get; set; }
            public int size { get; set; }
            public int vsize { get; set; }
            public int locktime { get; set; }
            public Vin[] vin { get; set; }
            public Vout[] vout { get; set; }
            public string hex { get; set; }
            public string blockhash { get; set; }
            public int height { get; set; }
            public int confirmations { get; set; }
            public int time { get; set; }
            public int blocktime { get; set; }
        }

        public class Vin
        {
            public string txid { get; set; }
            public int vout { get; set; }
            public Scriptsig scriptSig { get; set; }
            public long sequence { get; set; }
            public float value { get; set; }
            public long valueSat { get; set; }
            public string address { get; set; }
        }

        public class Scriptsig
        {
            public string asm { get; set; }
            public string hex { get; set; }
        }

        public class Vout
        {
            public float value { get; set; }
            public int n { get; set; }
            public Scriptpubkey scriptPubKey { get; set; }
            public long valueSat { get; set; }
        }

        public class Scriptpubkey
        {
            public string asm { get; set; }
            public string hex { get; set; }
            public int reqSigs { get; set; }
            public string type { get; set; }
            public string[] addresses { get; set; }
        }
    }
}
