using System;
using System.Net.Http;
using MoneyJars.Core.Helper;
using MoneyJars.Core.Interfaces;
using Newtonsoft.Json;

namespace MoneyJars.Core.Services
{
    public class DemoAPICall : IDemoAPICall
    {

        HttpClient _client;

        public DemoAPICall()
        {
        }

        public async void GetDetailAPI(Action<string> success, Action<Exception> error, string Param)
        {
            try
            {
                _client = new HttpClient();

                var uri = new Uri(string.Format(GlobalConst.BaseUrl + GlobalConst.UserLogin + Param));

                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var jsonResponse = JsonConvert.DeserializeObject<string>(content);

                    Console.WriteLine(jsonResponse);
                    success(jsonResponse);

                }
                else
                {
                    error(new Exception(""));
                    Console.WriteLine(response);
                }
            }
            catch (Exception ex)
            {
                error(ex);
            }
        }
    }
}
