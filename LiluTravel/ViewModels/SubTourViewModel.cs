using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiluTravel.ViewModels
{
    public class SubTourViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("tourId")]
        public int TourId { get; set; }

        [JsonProperty("images")]
        public List<ImageViewModel> Images { get; set; }
    }
}