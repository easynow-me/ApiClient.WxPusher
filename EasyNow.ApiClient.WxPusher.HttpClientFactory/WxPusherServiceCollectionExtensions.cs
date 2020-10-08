using System;
using EasyNow.ApiClient.WxPusher;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class WxPusherServiceCollectionExtensions
    {
        public static IServiceCollection AddWxPusher(this IServiceCollection services)
        {
            var settings = new RefitSettings
            {
                ContentSerializer = new NewtonsoftJsonContentSerializer(new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                })
            };
            services.AddRefitClient<IWxPusher>(settings).ConfigureHttpClient(c =>
            {
                c.BaseAddress = new Uri("https://wxpusher.zjiecode.com");
                c.Timeout = TimeSpan.FromDays(1);
            });
            return services;
        }
    }
}