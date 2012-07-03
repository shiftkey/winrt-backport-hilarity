using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Version(100794368u)]
	public struct SmsEncodedLength
	{
		public uint SegmentCount;
		public uint CharacterCountLastSegment;
		public uint CharactersPerSegment;
		public uint ByteCountLastSegment;
		public uint BytesPerSegment;
	}
}
