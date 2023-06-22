using System.Text;
using System.Text.Json;

namespace Behavioral.Tools.SeparateProcess;

public static class Tools
{
    public static StringContent PrepareStringContent<T>(T item) => new StringContent(
            JsonSerializer.Serialize(item),
            Encoding.Unicode,
            "application/json");
}