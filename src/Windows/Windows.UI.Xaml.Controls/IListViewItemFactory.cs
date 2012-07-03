using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ListViewItem)), Guid(4096853821u, 40108, 17058, 130, 223, 15, 68, 144, 188, 78, 46), Version(100794368u), WebHostHidden]
	internal interface IListViewItemFactory
	{
		ListViewItem CreateInstance([In] object outer, out object inner);
	}
}
