using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CalcountNew.Models
{
    public class FoodJsonItem
    {
        [JsonProperty("food_name")]
        public string food_name { get; set; }

        [JsonProperty("nf_calories")]
        public float nf_calories { get; set; }

        [JsonProperty("nf_total_fat")]
        public float nf_total_fat { get; set; }

        [JsonProperty("nf_total_carbohydrate")]
        public float nf_total_carbohydrate { get; set; }

        [JsonProperty("nf_protein")]
        public float nf_protein { get; set; }
    }
}
