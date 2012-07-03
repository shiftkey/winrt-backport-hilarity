using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Navigation;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Page)), Guid(3300028533u, 58945, 17726, 130, 77, 1, 47, 199, 207, 149, 207), Version(100794368u), WebHostHidden]
	internal interface IPage
	{
		AppBar BottomAppBar
		{
			get;
			set;
		}
		Frame Frame
		{
			get;
		}
		NavigationCacheMode NavigationCacheMode
		{
			get;
			set;
		}
		AppBar TopAppBar
		{
			get;
			set;
		}
	}
}
