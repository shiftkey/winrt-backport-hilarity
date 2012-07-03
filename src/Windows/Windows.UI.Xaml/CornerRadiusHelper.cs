using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ICornerRadiusHelperStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class CornerRadiusHelper : ICornerRadiusHelper
	{
		public static extern CornerRadius FromRadii([In] double topLeft, [In] double topRight, [In] double bottomRight, [In] double bottomLeft);
		public static extern CornerRadius FromUniformRadius([In] double uniformRadius);
	}
}
