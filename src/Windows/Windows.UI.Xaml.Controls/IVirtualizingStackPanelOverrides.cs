using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(VirtualizingStackPanel)), Guid(3420911404u, 10386, 18129, 152, 127, 88, 202, 16, 129, 240, 64), Version(100794368u), WebHostHidden]
	internal interface IVirtualizingStackPanelOverrides
	{
		void OnCleanUpVirtualizedItem([In] CleanUpVirtualizedItemEventArgs e);
	}
}
