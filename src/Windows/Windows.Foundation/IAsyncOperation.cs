using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(2680336571u, 58438, 17634, 170, 97, 156, 171, 143, 99, 106, 242), Version(100794368u)]
	public interface IAsyncOperation<TResult> : IAsyncInfo
	{
		AsyncOperationCompletedHandler<TResult> Completed
		{
			get;
			set;
		}
		TResult GetResults();
	}
}
