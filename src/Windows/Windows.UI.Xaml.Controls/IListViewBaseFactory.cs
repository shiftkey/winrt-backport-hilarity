using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ListViewBase)), Guid(3867044991u, 5391, 18128, 166, 172, 197, 0, 43, 217, 202, 83), Version(100794368u), WebHostHidden]
	internal interface IListViewBaseFactory
	{
		ListViewBase CreateInstance([In] object outer, out object inner);
	}
}
