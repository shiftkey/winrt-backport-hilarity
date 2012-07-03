using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(SelectorItem)), Guid(3107338565u, 51306, 19230, 148, 64, 24, 121, 55, 141, 83, 19), Version(100794368u), WebHostHidden]
	internal interface ISelectorItemFactory
	{
		SelectorItem CreateInstance([In] object outer, out object inner);
	}
}
