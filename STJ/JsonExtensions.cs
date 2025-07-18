using System.Text.Json;

namespace Moyu.JsonExtensions.STJ;

public static class JsonExtensions
{
    /// <summary>
    /// 将对象序列化为 JSON 字符串。
    /// </summary>
    public static string ToJson(this object obj, JsonSerializerOptions? options = null)
    {
        return JsonSerializer.Serialize(obj, options);
    }

    /// <summary>
    /// 从 JSON 字符串反序列化为对象。
    /// </summary>
    public static T? FromJson<T>(this string json, JsonSerializerOptions? options = null)
    {
        return JsonSerializer.Deserialize<T>(json, options);
    }
}
