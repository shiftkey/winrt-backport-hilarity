using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[ExclusiveTo(typeof(TargetFileRequestedEventArgs)), Guid(2976111553u, 6993, 19593, 165, 145, 15, 212, 11, 60, 87, 201), Version(100794368u)]
	internal interface ITargetFileRequestedEventArgs
	{
		TargetFileRequest Request
		{
			get;
		}
	}
}
