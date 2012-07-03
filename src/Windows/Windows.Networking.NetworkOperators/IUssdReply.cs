using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(UssdReply)), Guid(798674818u, 8197, 19805, 191, 129, 42, 186, 27, 75, 228, 168), Version(100794368u)]
	internal interface IUssdReply
	{
		UssdMessage Message
		{
			get;
		}
		UssdResultCode ResultCode
		{
			get;
		}
	}
}
