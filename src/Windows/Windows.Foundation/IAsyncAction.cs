using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(1516535814u, 33850, 19881, 134, 91, 157, 38, 229, 223, 173, 123), Version(100794368u)]
	public interface IAsyncAction : IAsyncInfo
	{
		AsyncActionCompletedHandler Completed
		{
			get;
			set;
		}
		void GetResults();
	}
}
