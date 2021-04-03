using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppRetetePDM.Services.Http
{
    public class HttpService
    {
        const string URL = @"https://raw.githubusercontent.com/petrediana/DAM/master/File.txt";
        public static async Task<string> Ceva()
        {
            HttpClient httpClient = new HttpClient();
            string result = await httpClient.GetStringAsync(URL);

            return result;
        }

    }
}
