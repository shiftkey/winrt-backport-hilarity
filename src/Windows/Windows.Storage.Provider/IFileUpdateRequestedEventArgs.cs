using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Provider
{
	[ExclusiveTo(typeof(FileUpdateRequestedEventArgs)), Guid(2064290626u, 14597, 17293, 170, 239, 120, 174, 38, 95, 141, 210), Version(100794368u)]
	internal interface IFileUpdateRequestedEventArgs
	{
		FileUpdateRequest Request
		{
			get;
		}
	}
}
