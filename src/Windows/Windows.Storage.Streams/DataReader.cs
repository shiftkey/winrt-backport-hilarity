using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[Activatable(typeof(IDataReaderFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IDataReaderStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class DataReader : IDataReader, IClosable
	{
		public extern ByteOrder ByteOrder
		{
			get;
			set;
		}
		public extern InputStreamOptions InputStreamOptions
		{
			get;
			set;
		}
		public extern uint UnconsumedBufferLength
		{
			get;
		}
		public extern UnicodeEncoding UnicodeEncoding
		{
			get;
			set;
		}
		public extern DataReader([In] IInputStream inputStream);
		public extern byte ReadByte();
		public extern void ReadBytes([Out] byte[] value);
		public extern IBuffer ReadBuffer([In] uint length);
		public extern bool ReadBoolean();
		public extern Guid ReadGuid();
		public extern short ReadInt16();
		public extern int ReadInt32();
		public extern long ReadInt64();
		public extern ushort ReadUInt16();
		public extern uint ReadUInt32();
		public extern ulong ReadUInt64();
		public extern float ReadSingle();
		public extern double ReadDouble();
		public extern string ReadString([In] uint codeUnitCount);
		public extern DateTime ReadDateTime();
		public extern TimeSpan ReadTimeSpan();
		public extern DataReaderLoadOperation LoadAsync([In] uint count);
		public extern IBuffer DetachBuffer();
		public extern IInputStream DetachStream();
		public extern void Close();
		public static extern DataReader FromBuffer([In] IBuffer buffer);
	}
}
