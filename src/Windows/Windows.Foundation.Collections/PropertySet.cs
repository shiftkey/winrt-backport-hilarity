using System;
using System.Collections.Generic;
using System.Linq;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
    [Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both)]
    public sealed class PropertySet : IPropertySet
    {
        readonly IDictionary<string, object> internalValues = new Dictionary<string, object>();

        public event MapChangedEventHandler<string, object> MapChanged;

        public uint Size { get { return (uint)internalValues.Count; } }

        public object Lookup(string key)
        {
            object result;
            if (internalValues.TryGetValue(key, out result))
            {
                return result;
            }
            return null;
        }

        public bool HasKey(string key)
        {
            return internalValues.ContainsKey(key);
        }
        
        public IMapView<string, object> GetView()
        {
            // TODO: what the fuck is this shit?
            throw new NotImplementedException("what the fuck is this shit");
        }

        public bool Insert(string key, object value)
        {
            internalValues.Add(key, value);
            return true;
        }
        
        public void Remove(string key) { }
        
        public void Clear() { }

        public IIterator<IKeyValuePair<string, object>> First()
        {
            var values = internalValues.Select(x => new KeyValuePairShim<string, object>(x.Key, x.Value));

            return new IteratorShim<IKeyValuePair<string, object>>(values.GetEnumerator());
        }
    }
}
