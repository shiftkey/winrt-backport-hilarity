using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(ResourceDictionary)), Guid(3929422261u, 12727, 17009, 146, 201, 124, 149, 132, 169, 28, 34), Version(100794368u), WebHostHidden]
	internal interface IResourceDictionaryFactory
	{
		ResourceDictionary CreateInstance([In] object outer, out object inner);
	}
}
