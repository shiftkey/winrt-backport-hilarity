using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
namespace Windows.Networking
{
	[ExclusiveTo(typeof(HostName)), Guid(3213806253u, 60822, 18855, 144, 132, 212, 22, 202, 232, 141, 203), Version(100794368u)]
	internal interface IHostName
	{
		string CanonicalName
		{
			get;
		}
		string DisplayName
		{
			get;
		}
		IPInformation IPInformation
		{
			get;
		}
		string RawName
		{
			get;
		}
		HostNameType Type
		{
			get;
		}
		bool IsEqual([In] HostName hostName);
	}
}
