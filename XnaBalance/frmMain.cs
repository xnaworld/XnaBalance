using System.Diagnostics;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Immutable;
using System.Web;

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
            string strTemp = GetXnaBalance(txtAddress.Text);
            Trace.WriteLine(strTemp);
            strTemp = GetAddressutxos(txtAddress.Text);
            Trace.WriteLine(strTemp);
        }

        protected string GetXnaBalance(string strAddress)
        {
            if (strAddress == "")
                return "";

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

        private void llAccountBalance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strTemp = GetAccountBalance();
            Trace.WriteLine(strTemp);
        }

        protected string GetAccountBalance()
        {
            //Set up any parameters we may need
            JObject parameters = new JObject();
            parameters.Add("account", "*");
            //parameters.Add("minconf ", 6);

            //Set up the Ravencoin Object
            XnaRequest request = new XnaRequest()
            {
                reqid = "0",
                reqmethod = "getbalance",
                reqparams = parameters,
                reqjsonrpc = "2.0"
            };

            //Send the Ravencoin Request Object to the Method that will call the node
            string response = XnaBalance.Connect(request);
            string strJson = response;// JsonHelper.ToJson(strTemp);
            bool bFlag = JsonHelper.IsJson(strJson);
            if (bFlag)
            {
                AccountBalance.Rootobject jo = (AccountBalance.Rootobject)JsonConvert.DeserializeObject<AccountBalance.Rootobject>(strJson);
                double dBalance = jo.result;// / 100000000.0;
                txtAccountBalance.Text = dBalance.ToString();
                //Trace.WriteLine(jo.getInfoResponse.isUtxoIndexed.ToString());
            }

            return response;
        }

        protected string GetAddressutxos(string strAddress)
        {
            //Set up any parameters we may need
            JObject parameters = new JObject();
            parameters.Add("addresses", strAddress);
            //parameters.Add("minconf ", 6);

            //Set up the Ravencoin Object
            XnaRequest request = new XnaRequest()
            {
                reqid = "0",
                reqmethod = "getaddressutxos",
                reqparams = parameters,
                reqjsonrpc = "2.0"
            };

            //Send the Ravencoin Request Object to the Method that will call the node
            string response = XnaBalance.Connect(request);
            string strJson = response;// JsonHelper.ToJson(strTemp);
            bool bFlag = JsonHelper.IsJson(strJson);
            if (bFlag)
            {
                getaddressutxos.Rootobject jo = (getaddressutxos.Rootobject)JsonConvert.DeserializeObject<getaddressutxos.Rootobject>(strJson);

                double dTotal = 0;
                if (jo != null)
                {
                    foreach (getaddressutxos.Result rr in jo.result)
                    {
                        string strTxid = rr.txid;

                        double dReturn  = GetRawtransaction(strTxid,strAddress);
                        dTotal += dReturn;
                    }
                }
               
                Trace.WriteLine("Total is ******----" + dTotal);
            }

            return response;
        }

        protected double GetRawtransaction(string strTxid, string strAddress)
        {
            //Set up any parameters we may need
            JObject parameters = new JObject();
            parameters.Add("txid", strTxid);
            parameters.Add("verbose", true);

            //Set up the Ravencoin Object
            XnaRequest request = new XnaRequest()
            {
                reqid = "0",
                reqmethod = "getrawtransaction",
                reqparams = parameters,
                reqjsonrpc = "2.0"
            };

            //Send the Ravencoin Request Object to the Method that will call the node
            string response = XnaBalance.Connect(request);
            string strJson = response;// JsonHelper.ToJson(strTemp);
            bool bFlag = JsonHelper.IsJson(strJson);
            //double dReturn = 0;
            double dTotal = 0;
            if (bFlag)
            {
                getrawtransaction.Rootobject jo = (getrawtransaction.Rootobject)JsonConvert.DeserializeObject<getrawtransaction.Rootobject>(strJson);

                if (jo != null)
                {
                    if (jo.result != null)
                    {
                        //Trace.WriteLine("receive count----" + jo.result.vout.Length);

                        string stRecentAddress = "";
                        float dValue = 0;
                        foreach (getrawtransaction.Vout vo in jo.result.vout)
                        {
                            stRecentAddress = vo.scriptPubKey.addresses[0];
                            dValue = vo.value;
                            if (strAddress == stRecentAddress)
                                dTotal = dTotal + dValue;
                            // if(vo.scriptPubKey.txt)

                            //Trace.WriteLine(dValue.ToString() + " " + txtRecentAddress.Text);
                        }

                        stRecentAddress = "";
                        foreach (getrawtransaction.Vin vi in jo.result.vin)
                        {
                            if (stRecentAddress == "")
                                stRecentAddress = vi.address;
                            else
                            {
                                if (stRecentAddress.IndexOf(vi.address) < 0)
                                    stRecentAddress = stRecentAddress + "," + vi.address;
                            }
                        }

                        txtRecentAddress.Text = stRecentAddress;
                        txtRecentAmount.Text = dTotal.ToString();
                        DateTime timeT = new DateTime(1970, 1, 1);
                        timeT = timeT.AddSeconds(jo.result.time);
                        lblTime.Text = timeT.ToString();

                        Trace.WriteLine(lblTime.Text + " " + dTotal + " " + txtRecentAddress.Text);
                    }
                }
            }

            return dTotal;
        }
    }
}