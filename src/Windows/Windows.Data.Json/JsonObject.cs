using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Data.Json
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IJsonObjectStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class JsonObject : IJsonObject, IJsonValue, IMap<string, IJsonValue>, IIterable<IKeyValuePair<string, IJsonValue>>
	{
		public extern JsonValueType ValueType
		{
			get;
		}
		public extern uint Size
		{
			get;
		}
		public extern JsonObject();
		public extern JsonValue GetNamedValue([In] string name);
		public extern void SetNamedValue([In] string name, [In] IJsonValue value);
		public extern JsonObject GetNamedObject([In] string name);
		public extern JsonArray GetNamedArray([In] string name);
		public extern string GetNamedString([In] string name);
		public extern double GetNamedNumber([In] string name);
		public extern bool GetNamedBoolean([In] string name);
		public extern string Stringify();
		public extern string GetString();
		public extern double GetNumber();
		public extern bool GetBoolean();
		public extern JsonArray GetArray();
		public extern JsonObject GetObject();
		public extern IJsonValue Lookup([In] string key);
		public extern bool HasKey([In] string key);
		public extern IMapView<string, IJsonValue> GetView();
		public extern bool Insert([In] string key, [In] IJsonValue value);
		public extern void Remove([In] string key);
		public extern void Clear();
		public extern IIterator<IKeyValuePair<string, IJsonValue>> First();
		public static extern JsonObject Parse([In] string input);
		public static extern bool TryParse([In] string input, out JsonObject result);
	}
}
