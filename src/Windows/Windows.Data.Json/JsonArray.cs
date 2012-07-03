using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Data.Json
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IJsonArrayStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class JsonArray : IJsonArray, IJsonValue, IVector<IJsonValue>, IIterable<IJsonValue>
	{
		public extern JsonValueType ValueType
		{
			get;
		}
		public extern uint Size
		{
			get;
		}
		public extern JsonArray();
		public extern JsonObject GetObjectAt([In] uint index);
		public extern JsonArray GetArrayAt([In] uint index);
		public extern string GetStringAt([In] uint index);
		public extern double GetNumberAt([In] uint index);
		public extern bool GetBooleanAt([In] uint index);
		public extern string Stringify();
		public extern string GetString();
		public extern double GetNumber();
		public extern bool GetBoolean();
		public extern JsonArray GetArray();
		public extern JsonObject GetObject();
		public extern IJsonValue GetAt([In] uint index);
		public extern IVectorView<IJsonValue> GetView();
		public extern bool IndexOf([In] IJsonValue value, out uint index);
		public extern void SetAt([In] uint index, [In] IJsonValue value);
		public extern void InsertAt([In] uint index, [In] IJsonValue value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] IJsonValue value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] IJsonValue[] items);
		public extern void ReplaceAll([In] IJsonValue[] items);
		public extern IIterator<IJsonValue> First();
		public static extern JsonArray Parse([In] string input);
		public static extern bool TryParse([In] string input, out JsonArray result);
	}
}
