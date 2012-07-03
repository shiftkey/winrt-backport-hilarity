using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;
namespace Windows.System
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class LauncherUIOptions : ILauncherUIOptions
	{
		public extern IReference<Point> InvocationPoint
		{
			get;
			set;
		}
		public extern Placement PreferredPlacement
		{
			get;
			set;
		}
		public extern IReference<Rect> SelectionRect
		{
			get;
			set;
		}
	}
}
