using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(MatrixHelper)), Guid(3246786214u, 14836, 19338, 132, 3, 40, 229, 229, 240, 51, 180), Version(100794368u), WebHostHidden]
	internal interface IMatrixHelperStatics
	{
		Matrix Identity
		{
			get;
		}
		Matrix FromElements([In] double m11, [In] double m12, [In] double m21, [In] double m22, [In] double offsetX, [In] double offsetY);
		bool GetIsIdentity([In] Matrix target);
		Point Transform([In] Matrix target, [In] Point point);
	}
}
