using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(CacheMode)), Guid(3944713307u, 2747, 20080, 184, 168, 98, 13, 13, 149, 58, 178), Version(100794368u), WebHostHidden]
	internal interface ICacheModeFactory
	{
		CacheMode CreateInstance([In] object outer, out object inner);
	}
}
