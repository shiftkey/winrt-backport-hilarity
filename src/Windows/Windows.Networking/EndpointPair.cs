using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking
{
	[Activatable(typeof(IEndpointPairFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class EndpointPair : IEndpointPair
	{
		public extern HostName LocalHostName
		{
			get;
			set;
		}
		public extern string LocalServiceName
		{
			get;
			set;
		}
		public extern HostName RemoteHostName
		{
			get;
			set;
		}
		public extern string RemoteServiceName
		{
			get;
			set;
		}
		public extern EndpointPair([In] HostName localHostName, [In] string localServiceName, [In] HostName remoteHostName, [In] string remoteServiceName);
	}
}
