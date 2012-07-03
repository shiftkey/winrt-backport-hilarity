using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Media3D
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IMatrix3DHelperStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class Matrix3DHelper : IMatrix3DHelper
	{
		public static extern Matrix3D Identity
		{
			get;
		}
		public static extern Matrix3D Multiply([In] Matrix3D matrix1, [In] Matrix3D matrix2);
		public static extern Matrix3D FromElements([In] double m11, [In] double m12, [In] double m13, [In] double m14, [In] double m21, [In] double m22, [In] double m23, [In] double m24, [In] double m31, [In] double m32, [In] double m33, [In] double m34, [In] double offsetX, [In] double offsetY, [In] double offsetZ, [In] double m44);
		public static extern bool GetHasInverse([In] Matrix3D target);
		public static extern bool GetIsIdentity([In] Matrix3D target);
		public static extern Matrix3D Invert([In] Matrix3D target);
	}
}
