using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(DataTransferManager)), Guid(2849636778u, 57358, 19710, 170, 68, 45, 217, 50, 220, 163, 216), Version(100794368u)]
	internal interface IDataTransferManagerStatics
	{
		void ShowShareUI();
		DataTransferManager GetForCurrentView();
	}
}
