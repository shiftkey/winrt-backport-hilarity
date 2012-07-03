using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ICryptographicBufferStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class CryptographicBuffer
	{
		public static extern bool Compare([In] IBuffer object1, [In] IBuffer object2);
		public static extern IBuffer GenerateRandom([In] uint length);
		public static extern uint GenerateRandomNumber();
		public static extern IBuffer CreateFromByteArray([In] byte[] value);
		public static extern void CopyToByteArray([In] IBuffer buffer, out byte[] value);
		public static extern IBuffer DecodeFromHexString([In] string value);
		public static extern string EncodeToHexString([In] IBuffer buffer);
		public static extern IBuffer DecodeFromBase64String([In] string value);
		public static extern string EncodeToBase64String([In] IBuffer buffer);
		public static extern IBuffer ConvertStringToBinary([In] string value, [In] BinaryStringEncoding encoding);
		public static extern string ConvertBinaryToString([In] BinaryStringEncoding encoding, [In] IBuffer buffer);
	}
}
