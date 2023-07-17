using System.Diagnostics;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace XnaBalance
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void llCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //BalanceCheck(txtAddress.Text);
            string strTemp = GetXnaBalance(txtAddress.Text);
            Trace.WriteLine(strTemp);
        }

        protected string GetXnaBalance(string strAddress)
        {
            //Set up any parameters we may need
            JObject parameters = new JObject();
            parameters.Add("addresses", strAddress);

            //Set up the Ravencoin Object
            XnaRequest request = new XnaRequest()
            {
                reqid = "0",
                reqmethod = "getaddressbalance",
                reqparams = parameters,
                reqjsonrpc = "2.0"
            };

            //Send the Ravencoin Request Object to the Method that will call the node
            string response = XnaBalance.Connect(request);
            string strJson = response;// JsonHelper.ToJson(strTemp);
            bool bFlag = JsonHelper.IsJson(strJson);
            if (bFlag)
            {
                GetBalance dd = new GetBalance();

                GetBalance.Rootobject jo = (GetBalance.Rootobject)JsonConvert.DeserializeObject<GetBalance.Rootobject>(strJson);
                double dBalance = jo.result.balance / 100000000.0;
                txtBalance.Text = dBalance.ToString();
                //Trace.WriteLine(jo.getInfoResponse.isUtxoIndexed.ToString());
            }

            return response;
        }
    }
}