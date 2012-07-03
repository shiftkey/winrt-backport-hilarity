using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ItemsControl)), Guid(4156277593u, 63741, 18204, 188, 178, 44, 116, 190, 142, 191, 140), Version(100794368u), WebHostHidden]
	internal interface IItemsControlFactory
	{
		ItemsControl CreateInstance([In] object outer, out object inner);
	}
}
