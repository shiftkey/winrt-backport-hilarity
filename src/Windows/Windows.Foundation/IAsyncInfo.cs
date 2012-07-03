namespace Windows.Foundation
{
	public interface IAsyncInfo
	{
		HResult ErrorCode { get; } 
        uint Id { get; }
		AsyncStatus Status { get; }
		void Cancel();
		void Close();
	}
}
