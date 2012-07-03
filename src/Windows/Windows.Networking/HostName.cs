using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
namespace Windows.Networking
{
	[Activatable(typeof(IHostNameFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IHostNameStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class HostName : IHostName
	{
		public extern string CanonicalName
		{
			get;
		}
		public extern string DisplayName
		{
			get;
		}
		public extern IPInformation IPInformation
		{
			get;
		}
		public extern string RawName
		{
			get;
		}
		public extern HostNameType Type
		{
			get;
		}
		public extern HostName([In] string hostName);
		public extern bool IsEqual([In] HostName hostName);
		public static extern int Compare([In] string value1, [In] string value2);
	}
}
