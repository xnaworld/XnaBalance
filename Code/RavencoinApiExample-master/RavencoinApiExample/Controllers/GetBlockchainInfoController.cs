using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace RavencoinApiExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetBlockchainInfoController
    {
        public string Get()
        {
            //Set up the Ravcencoin Object
            RavencoinRequest request = new RavencoinRequest()
            {
                reqid = "0",
                reqmethod = "getblockchaininfo",
                reqjsonrpc = "2.0"
            };

            //Send the Ravencoin Request Object to the Method that will call the node
            string response = Ravencore.Connect(request);

            return response;
        }
    }
}
