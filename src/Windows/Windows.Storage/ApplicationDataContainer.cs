using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ApplicationDataContainer : IApplicationDataContainer
	{
		public extern IMapView<string, ApplicationDataContainer> Containers
		{
			get;
		}
		public extern ApplicationDataLocality Locality
		{
			get;
		}
		public extern string Name
		{
			get;
		}
		public extern IPropertySet Values
		{
			get;
		}
		public extern ApplicationDataContainer CreateContainer([In] string name, [In] ApplicationDataCreateDisposition disposition);
		public extern void DeleteContainer([In] string name);
	}
}
