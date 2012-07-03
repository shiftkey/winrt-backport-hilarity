using System;
using Windows.Foundation.Metadata;
namespace Windows.System.Display
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.None), Threading(ThreadingModel.STA), Version(100794368u)]
	public sealed class DisplayRequest : IDisplayRequest
	{
		public extern DisplayRequest();
		public extern void RequestActive();
		public extern void RequestRelease();
	}
}
