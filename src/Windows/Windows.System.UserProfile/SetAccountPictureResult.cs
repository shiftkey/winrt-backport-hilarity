using System;
using Windows.Foundation.Metadata;
namespace Windows.System.UserProfile
{
	[Version(100794368u)]
	public enum SetAccountPictureResult
	{
		Success,
		ChangeDisabled,
		LargeOrDynamicError,
		VideoFrameSizeError,
		FileSizeError,
		Failure
	}
}
