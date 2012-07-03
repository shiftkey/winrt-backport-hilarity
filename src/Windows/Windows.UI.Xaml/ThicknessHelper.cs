using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IThicknessHelperStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ThicknessHelper : IThicknessHelper
	{
		public static extern Thickness FromLengths([In] double left, [In] double top, [In] double right, [In] double bottom);
		public static extern Thickness FromUniformLength([In] double uniformLength);
	}
}
