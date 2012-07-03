using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Navigation;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Page)), Guid(587963576u, 13337, 17158, 170, 190, 74, 142, 104, 13, 54, 39), Version(100794368u), WebHostHidden]
	internal interface IPageOverrides
	{
		void OnNavigatedFrom([In] NavigationEventArgs e);
		void OnNavigatedTo([In] NavigationEventArgs e);
		void OnNavigatingFrom([In] NavigatingCancelEventArgs e);
	}
}
