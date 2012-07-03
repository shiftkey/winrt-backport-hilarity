using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[Activatable(typeof(IUssdMessageFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class UssdMessage : IUssdMessage
	{
		public extern byte DataCodingScheme
		{
			get;
			set;
		}
		public extern string PayloadAsText
		{
			get;
			set;
		}
		public extern UssdMessage([In] string messageText);
		public extern byte[] GetPayload();
		public extern void SetPayload([Range(0, 160)] [In] byte[] value);
	}
}
