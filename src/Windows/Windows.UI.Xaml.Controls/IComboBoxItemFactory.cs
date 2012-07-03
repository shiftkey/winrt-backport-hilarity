using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ComboBoxItem)), Guid(2415913063u, 55628, 20103, 143, 196, 110, 188, 214, 60, 90, 194), Version(100794368u), WebHostHidden]
	internal interface IComboBoxItemFactory
	{
		ComboBoxItem CreateInstance([In] object outer, out object inner);
	}
}
