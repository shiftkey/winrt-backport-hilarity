using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(RangeBase)), Guid(949714033u, 21024, 17074, 153, 146, 38, 144, 193, 166, 112, 48), Version(100794368u), WebHostHidden]
	internal interface IRangeBaseFactory
	{
		RangeBase CreateInstance([In] object outer, out object inner);
	}
}
