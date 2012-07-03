using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel
{
	[Guid(2516982789u, 11706, 19720, 176, 189, 43, 48, 161, 49, 198, 170), Version(100794368u)]
	public interface ISuspendingEventArgs
	{
		SuspendingOperation SuspendingOperation
		{
			get;
		}
	}
}
