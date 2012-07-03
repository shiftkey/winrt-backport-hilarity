using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Media3D;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(Matrix3DProjection)), Guid(1862525257u, 49097, 19457, 181, 120, 80, 51, 140, 236, 151, 252), Version(100794368u), WebHostHidden]
	internal interface IMatrix3DProjection
	{
		Matrix3D ProjectionMatrix
		{
			get;
			set;
		}
	}
}
