using System.Runtime.InteropServices;

namespace Windows.Foundation
{
	public delegate void AsyncOperationProgressHandler<TResult, TProgress>(IAsyncOperationWithProgress<TResult, TProgress> asyncInfo, TProgress progressInfo);
}
