using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Json
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IJsonValueStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class JsonValue : IJsonValue
	{
		public extern JsonValueType ValueType
		{
			get;
		}
		public extern string Stringify();
		public extern string GetString();
		public extern double GetNumber();
		public extern bool GetBoolean();
		public extern JsonArray GetArray();
		public extern JsonObject GetObject();
		public static extern JsonValue Parse([In] string input);
		public static extern bool TryParse([In] string input, out JsonValue result);
		public static extern JsonValue CreateBooleanValue([In] bool input);
		public static extern JsonValue CreateNumberValue([In] double input);
		public static extern JsonValue CreateStringValue([In] string input);
	}
}
