using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Media3D;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(PlaneProjection)), Guid(3875023866u, 26406, 18074, 178, 89, 165, 24, 131, 71, 202, 143), Version(100794368u), WebHostHidden]
	internal interface IPlaneProjection
	{
		double CenterOfRotationX
		{
			get;
			set;
		}
		double CenterOfRotationY
		{
			get;
			set;
		}
		double CenterOfRotationZ
		{
			get;
			set;
		}
		double GlobalOffsetX
		{
			get;
			set;
		}
		double GlobalOffsetY
		{
			get;
			set;
		}
		double GlobalOffsetZ
		{
			get;
			set;
		}
		double LocalOffsetX
		{
			get;
			set;
		}
		double LocalOffsetY
		{
			get;
			set;
		}
		double LocalOffsetZ
		{
			get;
			set;
		}
		Matrix3D ProjectionMatrix
		{
			get;
		}
		double RotationX
		{
			get;
			set;
		}
		double RotationY
		{
			get;
			set;
		}
		double RotationZ
		{
			get;
			set;
		}
	}
}
