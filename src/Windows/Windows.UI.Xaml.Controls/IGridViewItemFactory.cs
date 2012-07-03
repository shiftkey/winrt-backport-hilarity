using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(GridViewItem)), Guid(580583599u, 16294, 17385, 151, 157, 7, 234, 13, 98, 128, 220), Version(100794368u), WebHostHidden]
	internal interface IGridViewItemFactory
	{
		GridViewItem CreateInstance([In] object outer, out object inner);
	}
}
