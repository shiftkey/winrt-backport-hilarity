using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Json
{
	[ExclusiveTo(typeof(JsonObject)), Guid(579465561u, 21726, 17880, 171, 204, 34, 96, 63, 160, 102, 160), Version(100794368u), WebHostHidden]
	internal interface IJsonObjectStatics
	{
		JsonObject Parse([In] string input);
		bool TryParse([In] string input, out JsonObject result);
	}
}
