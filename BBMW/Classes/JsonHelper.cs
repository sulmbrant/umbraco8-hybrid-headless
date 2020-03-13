using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;

namespace BBMW.Classes
{
    public static class JsonHelper
    {
        public static string GenerateJsonFromIPublishedContent(IPublishedContent model)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new PublishedContentContractResolver()
            };
            var serialized = JsonConvert.SerializeObject(model, Formatting.Indented, settings);

            return serialized;
        }

        public static string GenerateJsonFromNestedContent(object model)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new PublishedContentContractResolver()
            };
            var serialized = JsonConvert.SerializeObject(model, Formatting.Indented, settings);

            return serialized;
        }
    }
}