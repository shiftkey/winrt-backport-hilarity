using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[Version(100794368u)]
	public sealed class TargetFileRequest : ITargetFileRequest
	{
		public extern IStorageFile TargetFile
		{
			get;
			set;
		}
		public extern TargetFileRequestDeferral GetDeferral();
	}
}
