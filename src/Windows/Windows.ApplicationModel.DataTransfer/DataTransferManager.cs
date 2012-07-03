using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[MarshalingBehavior(MarshalingType.Standard), Static(typeof(IDataTransferManagerStatics), 100794368u), Version(100794368u)]
	public sealed class DataTransferManager : IDataTransferManager
	{
		public extern event TypedEventHandler<DataTransferManager, DataRequestedEventArgs> DataRequested
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<DataTransferManager, TargetApplicationChosenEventArgs> TargetApplicationChosen
		{
			add;
			remove;
		}
		public static extern void ShowShareUI();
		public static extern DataTransferManager GetForCurrentView();
	}
}
