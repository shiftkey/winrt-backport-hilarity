using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.ViewManagement
{
	[ExclusiveTo(typeof(InputPane)), Guid(1678432880u, 1779, 19591, 166, 120, 152, 41, 201, 18, 124, 40), Version(100794368u)]
	internal interface IInputPane
	{
		event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Hiding;
		event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Showing;
		Rect OccludedRect
		{
			get;
		}
	}
}
