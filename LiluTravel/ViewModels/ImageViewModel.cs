using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiluTravel.ViewModels
{
    public class ImageViewModel
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("active")]
        public string Active { get; set; }
    }
}