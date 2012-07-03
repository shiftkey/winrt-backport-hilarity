using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ToggleButton)), Guid(3580535548u, 64639, 17564, 152, 85, 122, 16, 85, 214, 104, 168), Version(100794368u), WebHostHidden]
	internal interface IToggleButtonFactory
	{
		ToggleButton CreateInstance([In] object outer, out object inner);
	}
}
