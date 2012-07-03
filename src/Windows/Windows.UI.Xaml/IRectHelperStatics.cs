using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(RectHelper)), Guid(1591829476u, 49534, 18767, 181, 128, 47, 5, 116, 252, 58, 21), Version(100794368u), WebHostHidden]
	internal interface IRectHelperStatics
	{
		Rect Empty
		{
			get;
		}
		Rect FromCoordinatesAndDimensions([In] float x, [In] float y, [In] float width, [In] float height);
		Rect FromPoints([In] Point point1, [In] Point point2);
		Rect FromLocationAndSize([In] Point location, [In] Size size);
		bool GetIsEmpty([In] Rect target);
		float GetBottom([In] Rect target);
		float GetLeft([In] Rect target);
		float GetRight([In] Rect target);
		float GetTop([In] Rect target);
		bool Contains([In] Rect target, [In] Point point);
		bool Equals([In] Rect target, [In] Rect value);
		Rect Intersect([In] Rect target, [In] Rect rect);
		[DefaultOverload, Overload("UnionWithPoint")]
		Rect Union([In] Rect target, [In] Point point);
		[Overload("UnionWithRect")]
		Rect Union([In] Rect target, [In] Rect rect);
	}
}
