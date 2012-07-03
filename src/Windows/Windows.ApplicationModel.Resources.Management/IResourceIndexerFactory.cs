using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Management
{
	[ExclusiveTo(typeof(ResourceIndexer)), Guid(3101572873u, 12749, 19863, 189, 48, 141, 57, 247, 66, 188, 97), Version(100794368u), WebHostHidden]
	internal interface IResourceIndexerFactory
	{
		ResourceIndexer CreateResourceIndexer([In] Uri projectRoot);
	}
}
