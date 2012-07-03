using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class ActivatedOperation : IActivatedOperation
	{
		public extern ActivatedDeferral GetDeferral();
	}
}
