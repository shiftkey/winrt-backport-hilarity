namespace Windows.Foundation
{
	public interface IAsyncOperation<TResult> : IAsyncInfo
	{
		AsyncOperationCompletedHandler<TResult> Completed { get; set; }
		TResult GetResults();
	}
}
