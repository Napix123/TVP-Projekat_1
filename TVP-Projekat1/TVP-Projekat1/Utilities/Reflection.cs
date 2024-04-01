

namespace Dash.Utilities
{
    internal static class Reflection
    {
        public static string GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null)?.ToString();
        }
    }
}
