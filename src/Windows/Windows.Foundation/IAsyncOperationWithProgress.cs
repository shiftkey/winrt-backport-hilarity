using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(3050321623u, 58007, 18831, 186, 96, 2, 137, 231, 110, 35, 221), Version(100794368u)]
	public interface IAsyncOperationWithProgress<TResult, TProgress> : IAsyncInfo
	{
		AsyncOperationProgressHandler<TResult, TProgress> Progress
		{
			get;
			set;
		}
		AsyncOperationWithProgressCompletedHandler<TResult, TProgress> Completed
		{
			get;
			set;
		}
		TResult GetResults();
	}
}
