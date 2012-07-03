using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(LineGeometry)), Guid(1468720995u, 21858, 20196, 135, 3, 234, 64, 54, 216, 145, 227), Version(100794368u), WebHostHidden]
	internal interface ILineGeometryStatics
	{
		DependencyProperty EndPointProperty
		{
			get;
		}
		DependencyProperty StartPointProperty
		{
			get;
		}
	}
}
