using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Control)), Guid(2972392794u, 25625, 19990, 178, 18, 164, 83, 54, 183, 87, 120), Version(100794368u), WebHostHidden]
	internal interface IControlFactory
	{
		Control CreateInstance([In] object outer, out object inner);
	}
}
