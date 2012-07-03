using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.ViewManagement
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class InputPaneVisibilityEventArgs : IInputPaneVisibilityEventArgs
	{
		public extern bool EnsuredFocusedElementInView
		{
			get;
			set;
		}
		public extern Rect OccludedRect
		{
			get;
		}
	}
}
