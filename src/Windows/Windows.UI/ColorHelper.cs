using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IColorHelperStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class ColorHelper : IColorHelper
	{
		public static extern Color FromArgb([In] byte a, [In] byte r, [In] byte g, [In] byte b);
	}
}
