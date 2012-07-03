using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[ExclusiveTo(typeof(BitmapTypedValue)), Guid(3447735465u, 9283, 16384, 176, 205, 121, 49, 108, 86, 245, 137), Version(100794368u)]
	internal interface IBitmapTypedValue
	{
		PropertyType Type
		{
			get;
		}
		object Value
		{
			get;
		}
	}
}
