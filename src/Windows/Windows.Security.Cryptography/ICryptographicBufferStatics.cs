using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography
{
	[ExclusiveTo(typeof(CryptographicBuffer)), Guid(839613986u, 15536, 19679, 134, 99, 29, 40, 145, 0, 101, 235), Version(100794368u)]
	internal interface ICryptographicBufferStatics
	{
		bool Compare([In] IBuffer object1, [In] IBuffer object2);
		IBuffer GenerateRandom([In] uint length);
		uint GenerateRandomNumber();
		IBuffer CreateFromByteArray([In] byte[] value);
		void CopyToByteArray([In] IBuffer buffer, out byte[] value);
		IBuffer DecodeFromHexString([In] string value);
		string EncodeToHexString([In] IBuffer buffer);
		IBuffer DecodeFromBase64String([In] string value);
		string EncodeToBase64String([In] IBuffer buffer);
		IBuffer ConvertStringToBinary([In] string value, [In] BinaryStringEncoding encoding);
		string ConvertBinaryToString([In] BinaryStringEncoding encoding, [In] IBuffer buffer);
	}
}
