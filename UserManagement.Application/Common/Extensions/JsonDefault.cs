using System.Text.Json;
using System.Text.Json.Serialization;

namespace Core.Application.Common.Extensions
{
    public class JsonDefault
    {

        private static readonly Lazy<JsonDefault> lazy = new Lazy<JsonDefault>(() => new JsonDefault());
        public readonly JsonSerializerOptions Options;
        public readonly JsonSerializerOptions Insensitive;

        private JsonDefault()
        {
            Options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            Options.Converters.Add(new JsonStringEnumConverter());
            Insensitive = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }
        public static JsonDefault Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}