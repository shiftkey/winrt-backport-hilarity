using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(Geometry)), Guid(2054204044u, 2822, 18015, 182, 55, 154, 71, 229, 167, 1, 17), Version(100794368u), WebHostHidden]
	internal interface IGeometryStatics
	{
		Geometry Empty
		{
			get;
		}
		double StandardFlatteningTolerance
		{
			get;
		}
		DependencyProperty TransformProperty
		{
			get;
		}
	}
}
