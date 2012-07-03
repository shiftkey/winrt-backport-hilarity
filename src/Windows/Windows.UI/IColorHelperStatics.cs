using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI
{
	[ExclusiveTo(typeof(ColorHelper)), Guid(2231688170u, 64362, 16708, 166, 194, 51, 73, 156, 146, 132, 245), Version(100794368u)]
	internal interface IColorHelperStatics
	{
		Color FromArgb([In] byte a, [In] byte r, [In] byte g, [In] byte b);
	}
}
