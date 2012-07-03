using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(StreamWebSocketControl)), Guid(3035920561u, 42074, 18651, 149, 58, 100, 91, 125, 150, 76, 7), Version(100794368u)]
	internal interface IStreamWebSocketControl : IWebSocketControl
	{
		bool NoDelay
		{
			get;
			set;
		}
	}
}
