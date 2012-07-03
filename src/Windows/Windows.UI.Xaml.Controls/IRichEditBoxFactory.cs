using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(RichEditBox)), Guid(1637998434u, 10246, 16877, 136, 237, 174, 33, 244, 122, 180, 34), Version(100794368u), WebHostHidden]
	internal interface IRichEditBoxFactory
	{
		RichEditBox CreateInstance([In] object outer, out object inner);
	}
}
