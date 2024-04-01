using Dash.Utilities;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;

namespace Dash.Extensions
{
    public static class String
    {
        public static string Replaceplaceholders(this string input, object target)
        {
            string copy = input;
            copy = Regex.Replace(copy, "{(.*?)}", match =>
            {
                return Reflection.GetPropertyValue(target, match.Groups[1].Value);
            });
            return copy;
        }
    }
}
