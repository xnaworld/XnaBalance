using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace RavencoinApiExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetTransactionController : ControllerBase
    {
        [HttpGet]
        public string Get(string txid)
        {
            //Set up parameters to get the hex string of the transaction
            JObject rawtxparameters = new JObject(
                new JProperty("txid", txid)
            );
            //Set up the Ravcencoin Object
            RavencoinRequest rawtxrequest = new RavencoinRequest()
            {
                reqid = "0",
                reqmethod = "getrawtransaction",
                reqparams = rawtxparameters,
                reqjsonrpc = "2.0"
            };

            //Get the hex string of the transaction back from getrawtransaction, and then parse it to get just the raw hex string from result
            JObject rawtxresponse = JObject.Parse((Ravencore.Connect(rawtxrequest)));
            JToken hexstring = rawtxresponse["result"];

            //Add the hex string to the next call to decode the raw transaction
            JObject decodetxparameters = new JObject(
                new JProperty("hexstring", hexstring)
            );

            //Set up the Ravcencoin Object
            RavencoinRequest request = new RavencoinRequest()
            {
                reqid = "0",
                reqmethod = "decoderawtransaction",
                reqparams = decodetxparameters,
                reqjsonrpc = "2.0"
            };

            //Get the Raw Transaction details for the transaction ID from the server.
            string response = Ravencore.Connect(request);

            return response;
        }
    }
}
