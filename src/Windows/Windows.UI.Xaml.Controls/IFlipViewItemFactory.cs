using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(FlipViewItem)), Guid(4062024190u, 8864, 17426, 168, 83, 157, 106, 110, 143, 42, 175), Version(100794368u), WebHostHidden]
	internal interface IFlipViewItemFactory
	{
		FlipViewItem CreateInstance([In] object outer, out object inner);
	}
}
