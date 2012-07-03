using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(ApplicationDataContainer))]
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
