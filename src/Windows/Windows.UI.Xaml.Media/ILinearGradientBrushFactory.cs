using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(LinearGradientBrush)), Guid(182486556u, 7802, 20461, 152, 87, 234, 140, 170, 121, 132, 144), Version(100794368u), WebHostHidden]
	internal interface ILinearGradientBrushFactory
	{
		LinearGradientBrush CreateInstanceWithGradientStopCollectionAndAngle([In] GradientStopCollection gradientStopCollection, [In] double angle);
	}
}
