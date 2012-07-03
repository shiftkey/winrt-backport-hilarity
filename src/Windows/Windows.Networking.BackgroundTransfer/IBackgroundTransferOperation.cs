using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.BackgroundTransfer
{
	[Guid(3738200134u, 37066, 17659, 143, 177, 18, 65, 84, 192, 213, 57), Version(100794368u)]
	public interface IBackgroundTransferOperation
	{
		BackgroundTransferCostPolicy CostPolicy
		{
			get;
			set;
		}
		string Group
		{
			get;
		}
		Guid Guid
		{
			get;
		}
		string Method
		{
			get;
		}
		Uri RequestedUri
		{
			get;
		}
		IInputStream GetResultStreamAt([In] ulong position);
		ResponseInformation GetResponseInformation();
	}
}
