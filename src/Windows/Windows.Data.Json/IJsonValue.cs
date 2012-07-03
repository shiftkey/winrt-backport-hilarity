using System;
using Windows.Foundation.Metadata;
namespace Windows.Data.Json
{
	[Guid(2736889547u, 61619, 19917, 190, 238, 25, 212, 140, 211, 237, 30), Version(100794368u), WebHostHidden]
	public interface IJsonValue
	{
		JsonValueType ValueType
		{
			get;
		}
		string Stringify();
		string GetString();
		double GetNumber();
		bool GetBoolean();
		JsonArray GetArray();
		JsonObject GetObject();
	}
}
