using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPropertyValueStatics), 100794368u), Threading(ThreadingModel.Both), WebHostHidden]
	public static class PropertyValue
	{
		public static extern object CreateEmpty();
		public static extern object CreateUInt8([In] byte value);
		public static extern object CreateInt16([In] short value);
		public static extern object CreateUInt16([In] ushort value);
		public static extern object CreateInt32([In] int value);
		public static extern object CreateUInt32([In] uint value);
		public static extern object CreateInt64([In] long value);
		public static extern object CreateUInt64([In] ulong value);
		public static extern object CreateSingle([In] float value);
		public static extern object CreateDouble([In] double value);
		public static extern object CreateChar16([In] char value);
		public static extern object CreateBoolean([In] bool value);
		public static extern object CreateString([In] string value);
		public static extern object CreateInspectable([In] object value);
		public static extern object CreateGuid([In] Guid value);
		public static extern object CreateDateTime([In] DateTime value);
		public static extern object CreateTimeSpan([In] TimeSpan value);
		public static extern object CreatePoint([In] Point value);
		public static extern object CreateSize([In] Size value);
		public static extern object CreateRect([In] Rect value);
		public static extern object CreateUInt8Array([In] byte[] value);
		public static extern object CreateInt16Array([In] short[] value);
		public static extern object CreateUInt16Array([In] ushort[] value);
		public static extern object CreateInt32Array([In] int[] value);
		public static extern object CreateUInt32Array([In] uint[] value);
		public static extern object CreateInt64Array([In] long[] value);
		public static extern object CreateUInt64Array([In] ulong[] value);
		public static extern object CreateSingleArray([In] float[] value);
		public static extern object CreateDoubleArray([In] double[] value);
		public static extern object CreateChar16Array([In] char[] value);
		public static extern object CreateBooleanArray([In] bool[] value);
		public static extern object CreateStringArray([In] string[] value);
		public static extern object CreateInspectableArray([In] object[] value);
		public static extern object CreateGuidArray([In] Guid[] value);
		public static extern object CreateDateTimeArray([In] DateTime[] value);
		public static extern object CreateTimeSpanArray([In] TimeSpan[] value);
		public static extern object CreatePointArray([In] Point[] value);
		public static extern object CreateSizeArray([In] Size[] value);
		public static extern object CreateRectArray([In] Rect[] value);
	}
}
