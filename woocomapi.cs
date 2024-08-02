using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json.Linq;

namespace wooAPI81
{
    class woocomapi
    {
        //private restclient 
        private RestClient client;
        private string baseurl = "https://cirrusaircraft.johnroberts.com/wp-json/wc/v3/";

        public woocomapi(string ck, string cs)
        {
            var options = new RestClientOptions(baseurl) { Authenticator = new HttpBasicAuthenticator(ck, cs) };
            client = new RestClient(options);
        }

       


        public order getOrder(string orderid)
        {
            var request = new RestRequest("orders/" + orderid);
            // Execute the request and get the response
            var response = client.Get<order>(request);
            return response;
        }

        public JObject getOrderAsJObject(string id)
        {
            var request = new RestRequest("orders/" + id);
            var response = client.Get(request);
            if (response.IsSuccessful)
            {
                return JObject.Parse(response.Content);
            }
            else
            {
                throw response.ErrorException;
            }
        }

        public string getProduct(string productid)
        {
            var request = new RestRequest("products/" + productid);
            // Execute the request and get the response
            var response = client.Get(request);
            if (response.IsSuccessful)
                return response.Content;
            else
                throw response.ErrorException;
        }

        public string getLocation(string location, string id)
        {
            var request = new RestRequest(location + "/" + id);
            // Execute the request and get the response
            var response = client.Get(request);
            if (response.IsSuccessful)
                return response.Content;
            else
                throw response.ErrorException;
        }

        ~woocomapi()
        {
            client.Dispose();
        }

    }
}
