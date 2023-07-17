﻿
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace XnaBalance
{
    public class XnaRequest
    {
        [JsonProperty(PropertyName = "id")]
        public string reqid { get; set; }

        [JsonProperty(PropertyName = "method")]
        public string reqmethod { get; set; }

        [JsonProperty(PropertyName = "params")]
        public JObject reqparams{get;set;}

        [JsonProperty(PropertyName = "jsonrpc")]
        public string reqjsonrpc { get; set; }

    }
}
