using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.ApplicationModel.Resources.Core
{
	[ExclusiveTo(typeof(ResourceManager)), Guid(4148484475u, 39304, 17659, 171, 214, 83, 120, 132, 76, 250, 139), Version(100794368u)]
	internal interface IResourceManager
	{
		IMapView<string, ResourceMap> AllResourceMaps
		{
			get;
		}
		ResourceContext DefaultContext
		{
			get;
		}
		ResourceMap MainResourceMap
		{
			get;
		}
		void LoadPriFiles([In] IIterable<IStorageFile> files);
		void UnloadPriFiles([In] IIterable<IStorageFile> files);
	}
}
