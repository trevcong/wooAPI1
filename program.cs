using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using System.Configuration;

namespace wooAPI81
{
    class Program
    {
        private static string ck = ConfigurationManager.AppSettings["clientkey"];
        private static string cs = ConfigurationManager.AppSettings["clientsecret"];

        static async Task Main(string[] args)
        {
            //string jsonresponse = await wooAPI(ck, cs);
            //woocomapi wooapi = new woocomapi(ck, cs);
            //order result = wooapi.getOrder("1554");
            //var orderjson = wooapi.getOrderAsJObject("1554");
            //string result = wooapi.getProduct("1556");
            //Console.WriteLine(result.id);
            //Console.WriteLine(orderjson.ToString());
            //Console.WriteLine(orderjson.Value<int>("id"));
            //Console.WriteLine(orderjson["billing"]["first_name"].ToString());
            Console.WriteLine(cs);
        }


        /**
        public static async Task<string> wooAPI(string ck, string cs)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://cirrusaircraft.johnroberts.com/wp-json/wc/v3/orders/1554"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(ck + ":" + cs));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    var response = await httpClient.SendAsync(request);
                    string resultjson = await response.Content.ReadAsStringAsync();
                    return resultjson;
                }
            }
        }
        **/
    }
}
