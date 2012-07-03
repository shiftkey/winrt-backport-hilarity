using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SuspendingOperation : ISuspendingOperation
	{
		public extern DateTime Deadline
		{
			get;
		}
		public extern SuspendingDeferral GetDeferral();
	}
}
