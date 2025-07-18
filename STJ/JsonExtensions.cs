using System.Text.Json;
using System.Text.Json.Nodes;

namespace Moyu.JsonExtensions.STJ;

/// <summary>
/// JSON 扩展方法类，为对象和 JSON 字符串之间的序列化/反序列化提供便捷方法。
/// </summary>
public static class JsonExtensions
{
    /// <summary>
    /// 将对象序列化为 JSON 字符串，使用指定的 <see cref="JsonSerializerOptions" />。
    /// </summary>
    /// <param name="obj">要序列化的对象。</param>
    /// <param name="options">JSON 序列化选项。</param>
    /// <returns>序列化后的 JSON 字符串。</returns>
    public static string ToJson(this object obj, JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(obj, options);
    }

    /// <summary>
    /// 从 JSON 字符串反序列化为对象，使用指定的 <see cref="JsonSerializerOptions" />。
    /// </summary>
    /// <typeparam name="T">目标对象的类型。</typeparam>
    /// <param name="json">JSON 字符串。</param>
    /// <param name="options">JSON 反序列化选项。</param>
    /// <returns>反序列化后的对象实例。</returns>
    public static T? FromJson<T>(this string json, JsonSerializerOptions options)
    {
        return JsonSerializer.Deserialize<T>(json, options);
    }

    /// <summary>
    /// 将对象序列化为 JSON 字符串，使用预设的 <see cref="JsonOptionType" /> 枚举选项。
    /// </summary>
    /// <param name="obj">要序列化的对象。</param>
    /// <param name="optionType">预设的 JSON 选项类型，默认为 EncEnumStrFields。</param>
    /// <returns>序列化后的 JSON 字符串。</returns>
    public static string ToJson(this object obj, JsonOptionType optionType = JsonOptionType.EncEnumStrFields)
    {
        var options = JsonOptionFactory.Create(optionType);
        return JsonSerializer.Serialize(obj, options);
    }

    /// <summary>
    /// 从 JSON 字符串反序列化为对象，使用预设的 <see cref="JsonOptionType" /> 枚举选项。
    /// </summary>
    /// <typeparam name="T">目标对象的类型。</typeparam>
    /// <param name="json">JSON 字符串。</param>
    /// <param name="optionType">预设的 JSON 选项类型，默认为 EncEnumStrFields。</param>
    /// <returns>反序列化后的对象实例。</returns>
    public static T? FromJson<T>(this string json, JsonOptionType optionType = JsonOptionType.EncEnumStrFields)
    {
        var options = JsonOptionFactory.Create(optionType);
        return JsonSerializer.Deserialize<T>(json, options);
    }

    /// <summary>
    /// 将对象序列化为 <see cref="JsonNode" />，使用指定的 <see cref="JsonSerializerOptions" />。
    /// </summary>
    /// <param name="obj">要序列化的对象。</param>
    /// <param name="options">JSON 序列化选项。</param>
    /// <returns>表示 JSON 数据结构的 <see cref="JsonNode" />，如果对象为 null，则返回 null。</returns>
    public static JsonNode? ToJsonNode(this object obj, JsonSerializerOptions options)
    {
        return JsonSerializer.SerializeToNode(obj, options);
    }

    /// <summary>
    /// 将对象序列化为 <see cref="JsonNode" />，使用预设的 <see cref="JsonOptionType" /> 枚举选项。
    /// </summary>
    /// <param name="obj">要序列化的对象。</param>
    /// <param name="optionType">预设的 JSON 选项类型，默认为 <see cref="JsonOptionType.EncEnumStrFields"/>。</param>
    /// <returns>表示 JSON 数据结构的 <see cref="JsonNode" />，如果对象为 null，则返回 null。</returns>
    public static JsonNode? ToJsonNode(this object obj, JsonOptionType optionType = JsonOptionType.EncEnumStrFields)
    {
        var options = JsonOptionFactory.Create(optionType);
        return JsonSerializer.SerializeToNode(obj, options);
    }
}
