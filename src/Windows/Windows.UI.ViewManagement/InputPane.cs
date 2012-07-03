using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.ViewManagement
{
	[MarshalingBehavior(MarshalingType.Standard), Static(typeof(IInputPaneStatics), 100794368u), Version(100794368u)]
	public sealed class InputPane : IInputPane
	{
		public extern event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Hiding
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Showing
		{
			add;
			remove;
		}
		public extern Rect OccludedRect
		{
			get;
		}
		public static extern InputPane GetForCurrentView();
	}
}
