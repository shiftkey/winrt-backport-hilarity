using System;
using Windows.Foundation.Metadata;
namespace Windows.Data.Json
{
	[Version(100794368u), WebHostHidden]
	public enum JsonValueType
	{
		Null,
		Boolean,
		Number,
		String,
		Array,
		Object
	}
}
