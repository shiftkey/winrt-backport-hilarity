using System;
using Windows.ApplicationModel;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class SuspendingDeferral : ISuspendingDeferral
	{
		public extern void Complete();
	}
}
