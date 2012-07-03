using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRectHelperStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class RectHelper : IRectHelper
	{
		public static extern Rect Empty
		{
			get;
		}
		public static extern Rect FromCoordinatesAndDimensions([In] float x, [In] float y, [In] float width, [In] float height);
		public static extern Rect FromPoints([In] Point point1, [In] Point point2);
		public static extern Rect FromLocationAndSize([In] Point location, [In] Size size);
		public static extern bool GetIsEmpty([In] Rect target);
		public static extern float GetBottom([In] Rect target);
		public static extern float GetLeft([In] Rect target);
		public static extern float GetRight([In] Rect target);
		public static extern float GetTop([In] Rect target);
		public static extern bool Contains([In] Rect target, [In] Point point);
		public static extern bool Equals([In] Rect target, [In] Rect value);
		public static extern Rect Intersect([In] Rect target, [In] Rect rect);
		[DefaultOverload, Overload("UnionWithPoint")]
		public static extern Rect Union([In] Rect target, [In] Point point);
		[Overload("UnionWithRect")]
		public static extern Rect Union([In] Rect target, [In] Rect rect);
	}
}
