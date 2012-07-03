using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Version(100794368u)]
	public enum PropertyType
	{
		Empty,
		UInt8,
		Int16,
		UInt16,
		Int32,
		UInt32,
		Int64,
		UInt64,
		Single,
		Double,
		Char16,
		Boolean,
		String,
		Inspectable,
		DateTime,
		TimeSpan,
		Guid,
		Point,
		Size,
		Rect,
		OtherType,
		UInt8Array = 1025,
		Int16Array,
		UInt16Array,
		Int32Array,
		UInt32Array,
		Int64Array,
		UInt64Array,
		SingleArray,
		DoubleArray,
		Char16Array,
		BooleanArray,
		StringArray,
		InspectableArray,
		DateTimeArray,
		TimeSpanArray,
		GuidArray,
		PointArray,
		SizeArray,
		RectArray,
		OtherTypeArray
	}
}
