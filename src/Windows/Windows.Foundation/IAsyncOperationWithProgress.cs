namespace Windows.Foundation
{
	public interface IAsyncOperationWithProgress<TResult, TProgress> : IAsyncInfo
	{
		AsyncOperationProgressHandler<TResult, TProgress> Progress { get; set; }
		AsyncOperationWithProgressCompletedHandler<TResult, TProgress> Completed { get; set; }
		TResult GetResults();
	}
}
