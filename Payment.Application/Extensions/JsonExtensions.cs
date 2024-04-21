using System.Text.Json;

namespace Payment.Application.Extensions
{
    public static class JsonExtensions
    {
        public static string ToJson<T>(this IList<T> obj)
        {
            return JsonSerializer.Serialize(obj);
        }

        public static string ToJson<T>(this T obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}
