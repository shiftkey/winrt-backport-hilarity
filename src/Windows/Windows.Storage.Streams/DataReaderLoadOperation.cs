using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DataReaderLoadOperation : IAsyncOperation<uint>, IAsyncInfo
	{
		public extern AsyncOperationCompletedHandler<uint> Completed
		{
			get;
			set;
		}
		public extern HResult ErrorCode
		{
			get;
		}
		public extern uint Id
		{
			get;
		}
		public extern AsyncStatus Status
		{
			get;
		}
		public extern uint GetResults();
		public extern void Cancel();
		public extern void Close();
	}
}
