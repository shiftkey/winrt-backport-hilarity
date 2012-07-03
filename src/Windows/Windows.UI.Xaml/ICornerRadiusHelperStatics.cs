using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(CornerRadiusHelper)), Guid(4104255065u, 54484, 17695, 163, 135, 214, 191, 75, 36, 81, 212), Version(100794368u), WebHostHidden]
	internal interface ICornerRadiusHelperStatics
	{
		CornerRadius FromRadii([In] double topLeft, [In] double topRight, [In] double bottomRight, [In] double bottomLeft);
		CornerRadius FromUniformRadius([In] double uniformRadius);
	}
}
