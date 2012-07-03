using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(ApplicationDataContainer)), Guid(3316579614u, 62567, 16570, 133, 102, 171, 100, 10, 68, 30, 29), Version(100794368u)]
	internal interface IApplicationDataContainer
	{
		IMapView<string, ApplicationDataContainer> Containers
		{
			get;
		}
		ApplicationDataLocality Locality
		{
			get;
		}
		string Name
		{
			get;
		}
		IPropertySet Values
		{
			get;
		}
		ApplicationDataContainer CreateContainer([In] string name, [In] ApplicationDataCreateDisposition disposition);
		void DeleteContainer([In] string name);
	}
}
