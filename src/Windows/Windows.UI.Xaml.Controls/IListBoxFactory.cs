using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ListBox)), Guid(1624112546u, 12100, 17483, 156, 148, 184, 201, 253, 164, 111, 89), Version(100794368u), WebHostHidden]
	internal interface IListBoxFactory
	{
		ListBox CreateInstance([In] object outer, out object inner);
	}
}
