using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(ManipulationPivot)), Guid(1829089337u, 14082, 17302, 173, 155, 168, 37, 239, 166, 58, 59), Version(100794368u), WebHostHidden]
	internal interface IManipulationPivotFactory
	{
		ManipulationPivot CreateInstanceWithCenterAndRadius([In] Point center, [In] double radius);
	}
}
