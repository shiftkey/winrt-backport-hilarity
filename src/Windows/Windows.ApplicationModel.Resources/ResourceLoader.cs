using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources
{
	[Activatable(100794368u), Activatable(typeof(IResourceLoaderFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IResourceLoaderStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class ResourceLoader : IResourceLoader
	{
		public extern ResourceLoader([In] string name);
		public extern ResourceLoader();
		public extern string GetString([In] string resource);
		public static extern string GetStringForReference([In] Uri uri);
	}
}
