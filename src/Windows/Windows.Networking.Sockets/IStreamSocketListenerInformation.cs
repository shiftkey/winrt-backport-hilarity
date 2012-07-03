using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(StreamSocketListenerInformation)), Guid(3861620783u, 42554, 17163, 191, 98, 41, 233, 62, 86, 51, 180), Version(100794368u)]
	internal interface IStreamSocketListenerInformation
	{
		string LocalPort
		{
			get;
		}
	}
}
