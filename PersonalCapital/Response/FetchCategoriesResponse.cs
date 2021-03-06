﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace PersonalCapital.Response {
    public class FetchCategoriesResponse {
        [JsonProperty(PropertyName = "spHeader")]
        public HeaderResponse Header { get; set; }

        [JsonProperty(PropertyName = "spData")]
        public List<CatagoryData> Data { get; set; }
    }
}
