using System.Text.Json;

namespace FoodResturant.Models
{
    public static class SessionExtentions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }
        public static T Get<T>(this ISession session, string key) 
        {
            var jason = session.GetString(key);
            if (string.IsNullOrEmpty(jason)) 
            { 
                return default(T);  
            }
            else 
            {
                return JsonSerializer.Deserialize<T>(jason);
            }
        
        }
    }
}
