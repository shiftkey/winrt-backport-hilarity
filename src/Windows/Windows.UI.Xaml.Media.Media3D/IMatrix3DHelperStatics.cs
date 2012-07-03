using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Media3D
{
	[ExclusiveTo(typeof(Matrix3DHelper)), Guid(2456048734u, 57688, 20084, 136, 153, 104, 145, 96, 189, 47, 140), Version(100794368u), WebHostHidden]
	internal interface IMatrix3DHelperStatics
	{
		Matrix3D Identity
		{
			get;
		}
		Matrix3D Multiply([In] Matrix3D matrix1, [In] Matrix3D matrix2);
		Matrix3D FromElements([In] double m11, [In] double m12, [In] double m13, [In] double m14, [In] double m21, [In] double m22, [In] double m23, [In] double m24, [In] double m31, [In] double m32, [In] double m33, [In] double m34, [In] double offsetX, [In] double offsetY, [In] double offsetZ, [In] double m44);
		bool GetHasInverse([In] Matrix3D target);
		bool GetIsIdentity([In] Matrix3D target);
		Matrix3D Invert([In] Matrix3D target);
	}
}
