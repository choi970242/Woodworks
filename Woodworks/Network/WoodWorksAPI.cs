using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Woodworks.Models;

namespace Woodworks.Network
{
    class WoodWorksAPI
    {
        private static string url = "http://192.168.1.141/~aldrichchoi/rpc/";

        public async static Task<string> runRequest<T>(string method, T param)
        {
            HttpClient client = new HttpClient();
            try {
                string request = formatRequest<T>(method, param);
                Console.WriteLine(request);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.PostAsync(url, new StringContent(request, Encoding.UTF8, "application/json"));
                string content = response.Content.ReadAsStringAsync().Result;
                return content;
            }
            catch(HttpRequestException hre)
            {
                Console.WriteLine(hre.Message);
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine("Canceled");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (client != null)
                {
                    client.Dispose();
                    client = null;
                }
            }
            return null;
        }
       
        public static string formatRequest<T>(string method, T param)
        {
            WoodWorksRequest<T> request = new WoodWorksRequest<T>(method,param);
            return JsonConvert.SerializeObject(request, Formatting.Indented);
        }

        public static string formatParam<T>(T param)
        {
            return JsonConvert.SerializeObject(param);
        }
    }
}
