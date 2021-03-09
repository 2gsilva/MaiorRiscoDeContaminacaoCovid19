using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MaiorRiscoDeContaminacaoCovid19.Models
{
    public class Countries
    {
        [JsonPropertyName("ID")]
        public int CountryId { get; set; }

        [JsonPropertyName("Country")]
        public string Coutry { get; set; }

        [JsonPropertyName("CountryCode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("TotalConfirmed")]
        public int TotalConfirmed { get; set; }

        [JsonPropertyName("TotalRecovered")]
        public int TotalRecovered { get; set; }
    }
}
