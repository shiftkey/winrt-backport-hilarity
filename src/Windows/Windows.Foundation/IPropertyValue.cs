using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(1272349405u, 30036, 16617, 154, 155, 130, 101, 78, 222, 126, 98), Version(100794368u)]
	public interface IPropertyValue
	{
		bool IsNumericScalar
		{
			get;
		}
		PropertyType Type
		{
			get;
		}
		byte GetUInt8();
		short GetInt16();
		ushort GetUInt16();
		int GetInt32();
		uint GetUInt32();
		long GetInt64();
		ulong GetUInt64();
		float GetSingle();
		double GetDouble();
		char GetChar16();
		bool GetBoolean();
		string GetString();
		Guid GetGuid();
		DateTime GetDateTime();
		TimeSpan GetTimeSpan();
		Point GetPoint();
		Size GetSize();
		Rect GetRect();
		void GetUInt8Array(out byte[] value);
		void GetInt16Array(out short[] value);
		void GetUInt16Array(out ushort[] value);
		void GetInt32Array(out int[] value);
		void GetUInt32Array(out uint[] value);
		void GetInt64Array(out long[] value);
		void GetUInt64Array(out ulong[] value);
		void GetSingleArray(out float[] value);
		void GetDoubleArray(out double[] value);
		void GetChar16Array(out char[] value);
		void GetBooleanArray(out bool[] value);
		void GetStringArray(out string[] value);
		void GetInspectableArray(out object[] value);
		void GetGuidArray(out Guid[] value);
		void GetDateTimeArray(out DateTime[] value);
		void GetTimeSpanArray(out TimeSpan[] value);
		void GetPointArray(out Point[] value);
		void GetSizeArray(out Size[] value);
		void GetRectArray(out Rect[] value);
	}
}
