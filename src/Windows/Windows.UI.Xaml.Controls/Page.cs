using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Navigation;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IPageFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPageStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Page : UserControl, IPage, IPageOverrides
	{
		public extern AppBar BottomAppBar
		{
			get;
			set;
		}
		public extern Frame Frame
		{
			get;
		}
		public extern NavigationCacheMode NavigationCacheMode
		{
			get;
			set;
		}
		public extern AppBar TopAppBar
		{
			get;
			set;
		}
		public static extern DependencyProperty BottomAppBarProperty
		{
			get;
		}
		public static extern DependencyProperty FrameProperty
		{
			get;
		}
		public static extern DependencyProperty TopAppBarProperty
		{
			get;
		}
		public extern Page();
		protected virtual extern void OnNavigatedFrom([In] NavigationEventArgs e);
		protected virtual extern void OnNavigatedTo([In] NavigationEventArgs e);
		protected virtual extern void OnNavigatingFrom([In] NavigatingCancelEventArgs e);
	}
}
