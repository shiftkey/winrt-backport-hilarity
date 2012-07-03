using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[ExclusiveTo(typeof(TargetFileRequest)), Guid(1119695701u, 32648, 18315, 142, 129, 105, 11, 32, 52, 6, 120), Version(100794368u)]
	internal interface ITargetFileRequest
	{
		IStorageFile TargetFile
		{
			get;
			set;
		}
		TargetFileRequestDeferral GetDeferral();
	}
}
