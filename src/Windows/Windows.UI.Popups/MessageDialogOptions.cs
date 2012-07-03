using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Popups
{
	[Flags, Version(100794368u)]
	public enum MessageDialogOptions : uint
	{
		None = 0u,
		AcceptUserInputAfterDelay = 1u
	}
}
