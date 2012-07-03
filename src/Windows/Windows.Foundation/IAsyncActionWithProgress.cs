using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(527282776u, 59395, 18593, 149, 70, 235, 115, 83, 57, 136, 132), Version(100794368u)]
	public interface IAsyncActionWithProgress<TProgress> : IAsyncInfo
	{
		AsyncActionProgressHandler<TProgress> Progress
		{
			get;
			set;
		}
		AsyncActionWithProgressCompletedHandler<TProgress> Completed
		{
			get;
			set;
		}
		void GetResults();
	}
}
