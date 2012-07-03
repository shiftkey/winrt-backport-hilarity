using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(1640068871u, 11621, 4576, 154, 232, 212, 133, 100, 1, 84, 114), Version(100794368u)]
	public interface IReferenceArray<T> : IPropertyValue
	{
		T[] Value
		{
			get;
		}
	}
}
