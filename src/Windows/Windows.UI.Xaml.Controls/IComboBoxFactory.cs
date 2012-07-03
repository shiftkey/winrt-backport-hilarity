using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ComboBox)), Guid(2886534212u, 42587, 19133, 134, 223, 48, 22, 4, 158, 254, 220), Version(100794368u), WebHostHidden]
	internal interface IComboBoxFactory
	{
		ComboBox CreateInstance([In] object outer, out object inner);
	}
}
