using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[DualApiPartition(version = 100794368u), Version(100794368u)]
	public sealed class UssdReply : IUssdReply
	{
		public extern UssdMessage Message
		{
			get;
		}
		public extern UssdResultCode ResultCode
		{
			get;
		}
	}
}
