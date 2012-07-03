using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SuspendingEventArgs : ISuspendingEventArgs
	{
		public extern SuspendingOperation SuspendingOperation
		{
			get;
		}
	}
}
