using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Navigation;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IFrameFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IFrameStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Frame : ContentControl, IFrame, INavigate
	{
		public extern event NavigatedEventHandler Navigated
		{
			add;
			remove;
		}
		public extern event NavigatingCancelEventHandler Navigating
		{
			add;
			remove;
		}
		public extern event NavigationFailedEventHandler NavigationFailed
		{
			add;
			remove;
		}
		public extern event NavigationStoppedEventHandler NavigationStopped
		{
			add;
			remove;
		}
		public extern int BackStackDepth
		{
			get;
		}
		public extern int CacheSize
		{
			get;
			set;
		}
		public extern bool CanGoBack
		{
			get;
		}
		public extern bool CanGoForward
		{
			get;
		}
		public extern TypeName CurrentSourcePageType
		{
			get;
		}
		public extern TypeName SourcePageType
		{
			get;
			set;
		}
		public static extern DependencyProperty BackStackDepthProperty
		{
			get;
		}
		public static extern DependencyProperty CacheSizeProperty
		{
			get;
		}
		public static extern DependencyProperty CanGoBackProperty
		{
			get;
		}
		public static extern DependencyProperty CanGoForwardProperty
		{
			get;
		}
		public static extern DependencyProperty CurrentSourcePageTypeProperty
		{
			get;
		}
		public static extern DependencyProperty SourcePageTypeProperty
		{
			get;
		}
		public extern Frame();
		public extern void GoBack();
		public extern void GoForward();
		public extern bool Navigate([In] TypeName sourcePageType, [In] object parameter);
		public extern string GetNavigationState();
		public extern void SetNavigationState([In] string navigationState);
		public extern bool Navigate([In] TypeName sourcePageType);
	}
}
