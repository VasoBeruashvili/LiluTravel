using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiluTravel.ViewModels
{
    public class TourViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }        

        [JsonProperty("images")]
        public List<ImageViewModel> Images { get; set; }

        [JsonProperty("subTours")]
        public List<SubTourViewModel> SubTours { get; set; }
    }
}