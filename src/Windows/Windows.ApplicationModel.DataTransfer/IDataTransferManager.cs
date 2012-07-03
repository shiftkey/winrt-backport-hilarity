using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(DataTransferManager)), Guid(2781539995u, 34568, 18897, 141, 54, 103, 210, 90, 141, 160, 12), Version(100794368u)]
	internal interface IDataTransferManager
	{
		event TypedEventHandler<DataTransferManager, DataRequestedEventArgs> DataRequested;
		event TypedEventHandler<DataTransferManager, TargetApplicationChosenEventArgs> TargetApplicationChosen;
	}
}
