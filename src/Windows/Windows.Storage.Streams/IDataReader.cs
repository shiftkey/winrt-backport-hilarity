using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[Guid(3803512873u, 46273, 17172, 164, 184, 251, 129, 58, 47, 39, 94), Version(100794368u)]
	public interface IDataReader
	{
		ByteOrder ByteOrder
		{
			get;
			set;
		}
		InputStreamOptions InputStreamOptions
		{
			get;
			set;
		}
		uint UnconsumedBufferLength
		{
			get;
		}
		UnicodeEncoding UnicodeEncoding
		{
			get;
			set;
		}
		byte ReadByte();
		void ReadBytes([Out] byte[] value);
		IBuffer ReadBuffer([In] uint length);
		bool ReadBoolean();
		Guid ReadGuid();
		short ReadInt16();
		int ReadInt32();
		long ReadInt64();
		ushort ReadUInt16();
		uint ReadUInt32();
		ulong ReadUInt64();
		float ReadSingle();
		double ReadDouble();
		string ReadString([In] uint codeUnitCount);
		DateTime ReadDateTime();
		TimeSpan ReadTimeSpan();
		DataReaderLoadOperation LoadAsync([In] uint count);
		IBuffer DetachBuffer();
		IInputStream DetachStream();
	}
}
