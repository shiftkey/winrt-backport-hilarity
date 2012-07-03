using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IMatrixHelperStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class MatrixHelper : IMatrixHelper
	{
		public static extern Matrix Identity
		{
			get;
		}
		public static extern Matrix FromElements([In] double m11, [In] double m12, [In] double m21, [In] double m22, [In] double offsetX, [In] double offsetY);
		public static extern bool GetIsIdentity([In] Matrix target);
		public static extern Point Transform([In] Matrix target, [In] Point point);
	}
}
