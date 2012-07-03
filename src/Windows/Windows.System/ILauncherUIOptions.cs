using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;
namespace Windows.System
{
	[ExclusiveTo(typeof(LauncherUIOptions)), Guid(455465582u, 35494, 16873, 130, 81, 65, 101, 245, 152, 95, 73), Version(100794368u)]
	internal interface ILauncherUIOptions
	{
		IReference<Point> InvocationPoint
		{
			get;
			set;
		}
		Placement PreferredPlacement
		{
			get;
			set;
		}
		IReference<Rect> SelectionRect
		{
			get;
			set;
		}
	}
}
