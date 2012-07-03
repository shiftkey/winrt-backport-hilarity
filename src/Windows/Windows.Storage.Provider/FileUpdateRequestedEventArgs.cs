using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Provider
{
	[Version(100794368u)]
	public sealed class FileUpdateRequestedEventArgs : IFileUpdateRequestedEventArgs
	{
		public extern FileUpdateRequest Request
		{
			get;
		}
	}
}
