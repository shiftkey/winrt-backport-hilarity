using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Core
{
	[ExclusiveTo(typeof(CoreApplication)), Guid(450498110u, 58530, 16675, 180, 81, 220, 150, 191, 128, 4, 25), Version(100794368u), WebHostHidden]
	internal interface ICoreImmersiveApplication
	{
		CoreApplicationView MainView
		{
			get;
		}
		IVectorView<CoreApplicationView> Views
		{
			get;
		}
		CoreApplicationView CreateNewView([In] string runtimeType, [In] string entryPoint);
	}
}
