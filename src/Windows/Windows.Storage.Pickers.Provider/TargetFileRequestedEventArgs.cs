using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[Version(100794368u)]
	public sealed class TargetFileRequestedEventArgs : ITargetFileRequestedEventArgs
	{
		public extern TargetFileRequest Request
		{
			get;
		}
	}
}
