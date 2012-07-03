using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[ExclusiveTo(typeof(PropertyValue)), Guid(1654381512u, 55602, 20468, 150, 185, 141, 150, 197, 193, 232, 88), Version(100794368u), WebHostHidden]
	internal interface IPropertyValueStatics
	{
		object CreateEmpty();
		object CreateUInt8([In] byte value);
		object CreateInt16([In] short value);
		object CreateUInt16([In] ushort value);
		object CreateInt32([In] int value);
		object CreateUInt32([In] uint value);
		object CreateInt64([In] long value);
		object CreateUInt64([In] ulong value);
		object CreateSingle([In] float value);
		object CreateDouble([In] double value);
		object CreateChar16([In] char value);
		object CreateBoolean([In] bool value);
		object CreateString([In] string value);
		object CreateInspectable([In] object value);
		object CreateGuid([In] Guid value);
		object CreateDateTime([In] DateTime value);
		object CreateTimeSpan([In] TimeSpan value);
		object CreatePoint([In] Point value);
		object CreateSize([In] Size value);
		object CreateRect([In] Rect value);
		object CreateUInt8Array([In] byte[] value);
		object CreateInt16Array([In] short[] value);
		object CreateUInt16Array([In] ushort[] value);
		object CreateInt32Array([In] int[] value);
		object CreateUInt32Array([In] uint[] value);
		object CreateInt64Array([In] long[] value);
		object CreateUInt64Array([In] ulong[] value);
		object CreateSingleArray([In] float[] value);
		object CreateDoubleArray([In] double[] value);
		object CreateChar16Array([In] char[] value);
		object CreateBooleanArray([In] bool[] value);
		object CreateStringArray([In] string[] value);
		object CreateInspectableArray([In] object[] value);
		object CreateGuidArray([In] Guid[] value);
		object CreateDateTimeArray([In] DateTime[] value);
		object CreateTimeSpanArray([In] TimeSpan[] value);
		object CreatePointArray([In] Point[] value);
		object CreateSizeArray([In] Size[] value);
		object CreateRectArray([In] Rect[] value);
	}
}
