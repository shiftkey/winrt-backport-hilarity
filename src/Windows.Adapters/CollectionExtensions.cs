using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Windows.Adapters
{
    public static class CollectionExtensions
    {
        public static ReadOnlyCollection<T> AsReadOnly<T>(this IList<T> list)
        {
            return new ReadOnlyCollection<T>(list);
        }
    }

    public static class TypeExtensions
    {
        public static void Close(this TextWriter writer)
        {
            writer.FlushAsync();
            writer.Dispose();
        }
        
    }
}
