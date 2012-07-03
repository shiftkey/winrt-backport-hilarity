using System;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class SuspendingOperation : ISuspendingOperation
	{
		public extern DateTime Deadline
		{
			get;
		}
		public extern Windows.ApplicationModel.SuspendingDeferral GetDeferral();
	}
}
