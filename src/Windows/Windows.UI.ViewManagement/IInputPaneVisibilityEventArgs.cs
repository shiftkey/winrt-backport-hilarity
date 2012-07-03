using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.ViewManagement
{
	[ExclusiveTo(typeof(InputPaneVisibilityEventArgs)), Guid(3527663638u, 55559, 20428, 187, 141, 247, 123, 170, 80, 40, 241), Version(100794368u)]
	internal interface IInputPaneVisibilityEventArgs
	{
		bool EnsuredFocusedElementInView
		{
			get;
			set;
		}
		Rect OccludedRect
		{
			get;
		}
	}
}
