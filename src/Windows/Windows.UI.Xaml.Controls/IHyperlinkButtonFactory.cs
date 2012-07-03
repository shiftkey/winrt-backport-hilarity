using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(HyperlinkButton)), Guid(1129454509u, 20119, 19881, 166, 77, 147, 93, 253, 140, 237, 242), Version(100794368u), WebHostHidden]
	internal interface IHyperlinkButtonFactory
	{
		HyperlinkButton CreateInstance([In] object outer, out object inner);
	}
}
