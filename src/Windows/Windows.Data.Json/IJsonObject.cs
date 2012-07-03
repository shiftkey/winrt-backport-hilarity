using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Json
{
	[ExclusiveTo(typeof(JsonObject)), Guid(105784541u, 10690, 20355, 154, 193, 158, 225, 21, 120, 190, 179), Version(100794368u), WebHostHidden]
	internal interface IJsonObject : IJsonValue
	{
		JsonValue GetNamedValue([In] string name);
		void SetNamedValue([In] string name, [In] IJsonValue value);
		JsonObject GetNamedObject([In] string name);
		JsonArray GetNamedArray([In] string name);
		string GetNamedString([In] string name);
		double GetNamedNumber([In] string name);
		bool GetNamedBoolean([In] string name);
	}
}
