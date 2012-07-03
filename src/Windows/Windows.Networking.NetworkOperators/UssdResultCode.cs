using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[Version(100794368u)]
	public enum UssdResultCode
	{
		NoActionRequired,
		ActionRequired,
		Terminated,
		OtherLocalClient,
		OperationNotSupported,
		NetworkTimeout
	}
}
