using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.BackgroundTransfer
{
	[ExclusiveTo(typeof(ResponseInformation)), Guid(4173044242u, 63251, 18322, 139, 104, 217, 210, 151, 249, 29, 46), Version(100794368u)]
	internal interface IResponseInformation
	{
		Uri ActualUri
		{
			get;
		}
		IMapView<string, string> Headers
		{
			get;
		}
		bool IsResumable
		{
			get;
		}
		uint StatusCode
		{
			get;
		}
	}
}
