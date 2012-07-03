using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking
{
	[ExclusiveTo(typeof(EndpointPair)), Guid(866167350u, 63738, 19248, 184, 86, 118, 81, 124, 59, 208, 109), Version(100794368u)]
	internal interface IEndpointPair
	{
		HostName LocalHostName
		{
			get;
			set;
		}
		string LocalServiceName
		{
			get;
			set;
		}
		HostName RemoteHostName
		{
			get;
			set;
		}
		string RemoteServiceName
		{
			get;
			set;
		}
	}
}
