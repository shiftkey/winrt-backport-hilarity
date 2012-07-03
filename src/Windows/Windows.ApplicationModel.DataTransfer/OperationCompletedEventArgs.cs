using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class OperationCompletedEventArgs : IOperationCompletedEventArgs
	{
		public extern DataPackageOperation Operation
		{
			get;
		}
	}
}
