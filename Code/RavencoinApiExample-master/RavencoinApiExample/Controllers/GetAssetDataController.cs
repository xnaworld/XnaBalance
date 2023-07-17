using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace RavencoinApiExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetAssetDataController
    {
        public string Get(string asset)
        {
            //Set up any parameters we may need
            JObject parameters = new JObject();
            parameters.Add("asset_name", asset);

            //Set up the Ravencoin Object
            RavencoinRequest request = new RavencoinRequest()
            {
                reqid = "0",
                reqmethod = "getassetdata",
                reqparams = parameters,
                reqjsonrpc = "2.0"
            };

            //Send the Ravencoin Request Object to the Method that will call the node
            string response = Ravencore.Connect(request);

            return response;
        }
    }
}
