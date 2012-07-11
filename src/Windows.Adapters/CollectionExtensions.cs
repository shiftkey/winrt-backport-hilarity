using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;

namespace Windows.Adapters
{
    public static class CollectionExtensions
    {
        public static ReadOnlyCollection<T> AsReadOnly<T>(this IList<T> list)
        {
            return new ReadOnlyCollection<T>(list);
        }
    
        public static void Close(this TextWriter writer)
        {
            writer.FlushAsync();
            writer.Dispose();
        }

        public static string ToUpper(this string value, CultureInfo cultureInfo)
        {
            if (Equals(cultureInfo, CultureInfo.InvariantCulture))
            {
                return value.ToUpperInvariant();    
            }

            return value.ToUpper();
        }
    }
}
