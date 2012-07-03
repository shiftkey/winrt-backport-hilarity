namespace Windows.Foundation
{
	public interface IAsyncAction : IAsyncInfo
	{
		AsyncActionCompletedHandler Completed { get; set; }
		void GetResults();
	}
}
