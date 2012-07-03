using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(DataRequestedEventArgs)), Guid(3414927367u, 27333, 17353, 138, 197, 155, 162, 50, 22, 49, 130), Version(100794368u)]
	internal interface IDataRequestedEventArgs
	{
		DataRequest Request
		{
			get;
		}
	}
}
