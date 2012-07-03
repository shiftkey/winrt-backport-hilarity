using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(Geometry)), Guid(4195498121u, 2765, 16763, 182, 45, 92, 161, 191, 77, 252, 14), Version(100794368u), WebHostHidden]
	internal interface IGeometry
	{
		Rect Bounds
		{
			get;
		}
		Transform Transform
		{
			get;
			set;
		}
	}
}
