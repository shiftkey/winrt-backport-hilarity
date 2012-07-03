using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Shapes
{
	[ExclusiveTo(typeof(Shape)), Guid(1265726995u, 63146, 18645, 149, 136, 225, 209, 136, 234, 203, 201), Version(100794368u), WebHostHidden]
	internal interface IShapeFactory
	{
		Shape CreateInstance([In] object outer, out object inner);
	}
}
