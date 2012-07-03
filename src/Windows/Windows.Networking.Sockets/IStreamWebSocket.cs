using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(StreamWebSocket)), Guid(3175762392u, 45705, 17851, 151, 235, 199, 82, 82, 5, 168, 67), Version(100794368u)]
	internal interface IStreamWebSocket : IWebSocket, IClosable
	{
		StreamWebSocketControl Control
		{
			get;
		}
		StreamWebSocketInformation Information
		{
			get;
		}
		IInputStream InputStream
		{
			get;
		}
	}
}
