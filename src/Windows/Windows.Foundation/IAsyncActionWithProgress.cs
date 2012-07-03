namespace Windows.Foundation
{
	public interface IAsyncActionWithProgress<TProgress> : IAsyncInfo
	{
		AsyncActionProgressHandler<TProgress> Progress { get; set; }
		AsyncActionWithProgressCompletedHandler<TProgress> Completed { get; set; }
		void GetResults();
	}
}
