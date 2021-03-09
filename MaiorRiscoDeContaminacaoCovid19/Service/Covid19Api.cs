using MaiorRiscoDeContaminacaoCovid19.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace MaiorRiscoDeContaminacaoCovid19.Service
{
    public class Covid19Api
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string uri = "https://api.covid19api.com/summary";

        public async Task<CountriesJson> OterPaisesMaisCasos() 
        {
            var requisicao =  await client.GetStringAsync(uri);
            
            return JsonConvert.DeserializeObject<CountriesJson>(requisicao);
        }
    }
}
