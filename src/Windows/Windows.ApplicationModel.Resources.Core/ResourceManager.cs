using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.ApplicationModel.Resources.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IResourceManagerStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class ResourceManager : IResourceManager
	{
		public extern IMapView<string, ResourceMap> AllResourceMaps
		{
			get;
		}
		public extern ResourceContext DefaultContext
		{
			get;
		}
		public extern ResourceMap MainResourceMap
		{
			get;
		}
		public static extern ResourceManager Current
		{
			get;
		}
		public extern void LoadPriFiles([In] IIterable<IStorageFile> files);
		public extern void UnloadPriFiles([In] IIterable<IStorageFile> files);
		public static extern bool IsResourceReference([In] string resourceReference);
	}
}
