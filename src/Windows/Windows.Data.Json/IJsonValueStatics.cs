using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Json
{
	[ExclusiveTo(typeof(JsonValue)), Guid(1600869450u, 12115, 18657, 145, 163, 247, 139, 80, 166, 52, 92), Version(100794368u), WebHostHidden]
	internal interface IJsonValueStatics
	{
		JsonValue Parse([In] string input);
		bool TryParse([In] string input, out JsonValue result);
		JsonValue CreateBooleanValue([In] bool input);
		JsonValue CreateNumberValue([In] double input);
		JsonValue CreateStringValue([In] string input);
	}
}
