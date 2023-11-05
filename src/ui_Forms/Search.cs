using core;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ui_Forms
{
    internal class Search
    {
        public static async Task<List<SearchResponse>> PostSearchRequest(HttpClient sharedClient, string SearchBar, List<string> SelectedCategorys)
        {
            List<string> Categorys = new List<string>();
            Categorys.Add("Moin");
            Categorys.Add("Neger");
            SearchRequest search = new SearchRequest("hello1", "moinneer", Categorys);

            var leckmich = JsonContent.Create(search);

            var response = sharedClient.PostAsync("Search", leckmich).Result;

            if(response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<SearchResponse>>(responseContent)!;
            }

            return null;
        }
    }
}
