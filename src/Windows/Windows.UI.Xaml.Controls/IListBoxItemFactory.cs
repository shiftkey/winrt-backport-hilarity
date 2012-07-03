using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ListBoxItem)), Guid(1134082260u, 41950, 16428, 178, 61, 25, 3, 132, 178, 124, 168), Version(100794368u), WebHostHidden]
	internal interface IListBoxItemFactory
	{
		ListBoxItem CreateInstance([In] object outer, out object inner);
	}
}
