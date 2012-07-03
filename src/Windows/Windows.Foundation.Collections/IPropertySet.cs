using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	[Guid(2319707551u, 62694, 17441, 172, 249, 29, 171, 41, 134, 130, 12), HasVariant, Version(100794368u)]
	public interface IPropertySet : IObservableMap<string, object>, IMap<string, object>, IIterable<IKeyValuePair<string, object>>
	{
	}
}
