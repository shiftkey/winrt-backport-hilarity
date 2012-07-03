using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.BackgroundTransfer
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ResponseInformation : IResponseInformation
	{
		public extern Uri ActualUri
		{
			get;
		}
		public extern IMapView<string, string> Headers
		{
			get;
		}
		public extern bool IsResumable
		{
			get;
		}
		public extern uint StatusCode
		{
			get;
		}
	}
}
