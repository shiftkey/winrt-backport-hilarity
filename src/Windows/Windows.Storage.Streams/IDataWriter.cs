using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using TimeSpan = Windows.Foundation.TimeSpan;
using DateTime = Windows.Foundation.DateTime;

namespace Windows.Storage.Streams
{
    public interface IDataWriter
	{
		ByteOrder ByteOrder
		{
			get;
			set;
		}
		UnicodeEncoding UnicodeEncoding
		{
			get;
			set;
		}
		uint UnstoredBufferLength
		{
			get;
		}
		void WriteByte([In] byte value);
		void WriteBytes([In] byte[] value);
		[Overload("WriteBuffer")]
		void WriteBuffer([In] IBuffer buffer);
		[Overload("WriteBufferRange")]
		void WriteBuffer([In] IBuffer buffer, [In] uint start, [In] uint count);
		void WriteBoolean([In] bool value);
		void WriteGuid([In] Guid value);
		void WriteInt16([In] short value);
		void WriteInt32([In] int value);
		void WriteInt64([In] long value);
		void WriteUInt16([In] ushort value);
		void WriteUInt32([In] uint value);
		void WriteUInt64([In] ulong value);
		void WriteSingle([In] float value);
		void WriteDouble([In] double value);
		void WriteDateTime([In] DateTime value);
		void WriteTimeSpan([In] TimeSpan value);
		uint WriteString([In] string value);
		uint MeasureString([In] string value);
		DataWriterStoreOperation StoreAsync();
		IAsyncOperation<bool> FlushAsync();
		IBuffer DetachBuffer();
		IOutputStream DetachStream();
	}
}
