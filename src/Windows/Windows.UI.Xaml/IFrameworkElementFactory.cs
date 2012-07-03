using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(FrameworkElement)), Guid(3736002854u, 970, 18790, 181, 118, 96, 76, 206, 147, 181, 232), Version(100794368u), WebHostHidden]
	internal interface IFrameworkElementFactory
	{
		FrameworkElement CreateInstance([In] object outer, out object inner);
	}
}
