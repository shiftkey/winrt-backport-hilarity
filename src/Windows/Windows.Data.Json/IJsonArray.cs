using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Json
{
	[ExclusiveTo(typeof(JsonArray)), Guid(146922934u, 3261, 19098, 181, 211, 47, 133, 45, 195, 126, 129), Version(100794368u), WebHostHidden]
	internal interface IJsonArray : IJsonValue
	{
		JsonObject GetObjectAt([In] uint index);
		JsonArray GetArrayAt([In] uint index);
		string GetStringAt([In] uint index);
		double GetNumberAt([In] uint index);
		bool GetBooleanAt([In] uint index);
	}
}
