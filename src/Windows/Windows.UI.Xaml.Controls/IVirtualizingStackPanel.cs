using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(VirtualizingStackPanel)), Guid(1969737114u, 41908, 19946, 187, 17, 84, 158, 44, 47, 145, 157), Version(100794368u), WebHostHidden]
	internal interface IVirtualizingStackPanel
	{
		event CleanUpVirtualizedItemEventHandler CleanUpVirtualizedItemEvent;
		bool AreScrollSnapPointsRegular
		{
			get;
			set;
		}
		Orientation Orientation
		{
			get;
			set;
		}
	}
}
