using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Panel)), Guid(4008083729u, 51148, 17215, 149, 205, 214, 48, 195, 67, 2, 221), Version(100794368u), WebHostHidden]
	internal interface IPanelFactory
	{
		Panel CreateInstance([In] object outer, out object inner);
	}
}
