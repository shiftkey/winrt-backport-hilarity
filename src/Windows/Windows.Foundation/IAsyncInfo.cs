using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(54u, 0, 0, 192, 0, 0, 0, 0, 0, 0, 70), Version(100794368u)]
	public interface IAsyncInfo
	{
		HResult ErrorCode
		{
			get;
		}
		uint Id
		{
			get;
		}
		AsyncStatus Status
		{
			get;
		}
		void Cancel();
		void Close();
	}
}
