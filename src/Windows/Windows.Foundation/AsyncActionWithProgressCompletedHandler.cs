namespace Windows.Foundation
{
	public delegate void AsyncActionWithProgressCompletedHandler<TProgress>(IAsyncActionWithProgress<TProgress> asyncInfo, AsyncStatus asyncStatus);
}
