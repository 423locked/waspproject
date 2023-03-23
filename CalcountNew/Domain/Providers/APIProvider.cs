using Flurl.Http;
using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Calcount.Domain.Providers
{
    public static class APIProvider
    {
        public static async Task<string> GetMealJsonAsync(string query)
        {
            try
            {
                return await Configuration.APIUri
                    .WithHeader("x-app-id", Configuration.AppID)
                    .WithHeader("x-app-key", Configuration.APIToken)
                    .PostJsonAsync(new
                    {
                        query = query
                    })
                    .ReceiveString();
            }
            catch(Exception e)
            {
                return string.Empty;
            }
        }
    }
}
