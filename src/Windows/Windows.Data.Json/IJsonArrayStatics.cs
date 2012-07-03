using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Json
{
	[ExclusiveTo(typeof(JsonArray)), Guid(3675534505u, 57700, 18847, 147, 226, 138, 143, 73, 187, 144, 186), Version(100794368u), WebHostHidden]
	internal interface IJsonArrayStatics
	{
		JsonArray Parse([In] string input);
		bool TryParse([In] string input, out JsonArray result);
	}
}
