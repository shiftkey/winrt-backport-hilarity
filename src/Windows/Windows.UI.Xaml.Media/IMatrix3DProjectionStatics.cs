using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(Matrix3DProjection)), Guid(2929547413u, 16876, 20023, 171, 170, 105, 244, 29, 47, 135, 107), Version(100794368u), WebHostHidden]
	internal interface IMatrix3DProjectionStatics
	{
		DependencyProperty ProjectionMatrixProperty
		{
			get;
		}
	}
}
