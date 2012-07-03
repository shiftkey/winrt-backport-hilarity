using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using TimeSpan = Windows.Foundation.TimeSpan;
using DateTime = Windows.Foundation.DateTime;


namespace Windows.Storage.Streams
{
	[Activatable(typeof(IDataWriterFactory), 100794368u), Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both)]
	public sealed class DataWriter : IDataWriter, IClosable
	{
		public extern ByteOrder ByteOrder
		{
			get;
			set;
		}
		public extern UnicodeEncoding UnicodeEncoding
		{
			get;
			set;
		}
		public extern uint UnstoredBufferLength
		{
			get;
		}
		public extern DataWriter([In] IOutputStream outputStream);
		public extern DataWriter();
		public extern void WriteByte([In] byte value);
		public extern void WriteBytes([In] byte[] value);
		[Overload("WriteBuffer")]
		public extern void WriteBuffer([In] IBuffer buffer);
		[Overload("WriteBufferRange")]
		public extern void WriteBuffer([In] IBuffer buffer, [In] uint start, [In] uint count);
		public extern void WriteBoolean([In] bool value);
		public extern void WriteGuid([In] Guid value);
		public extern void WriteInt16([In] short value);
		public extern void WriteInt32([In] int value);
		public extern void WriteInt64([In] long value);
		public extern void WriteUInt16([In] ushort value);
		public extern void WriteUInt32([In] uint value);
		public extern void WriteUInt64([In] ulong value);
		public extern void WriteSingle([In] float value);
		public extern void WriteDouble([In] double value);
		public extern void WriteDateTime([In] DateTime value);
		public extern void WriteTimeSpan([In] TimeSpan value);
		public extern uint WriteString([In] string value);
		public extern uint MeasureString([In] string value);
		public extern DataWriterStoreOperation StoreAsync();
		public extern IAsyncOperation<bool> FlushAsync();
		public extern IBuffer DetachBuffer();
		public extern IOutputStream DetachStream();
		public extern void Close();
	}
}
