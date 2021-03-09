using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaiorRiscoDeContaminacaoCovid19.Models
{
    public class CountriesJson
    {
        [JsonProperty("Countries")]
        public IEnumerable<Countries> Countries { get; set; }
    }
}
