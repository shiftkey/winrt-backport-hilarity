using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Navigation;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Frame)), Guid(1760186379u, 16361, 18229, 182, 160, 231, 96, 25, 51, 176, 137), Version(100794368u), WebHostHidden]
	internal interface IFrame
	{
		event NavigatedEventHandler Navigated;
		event NavigatingCancelEventHandler Navigating;
		event NavigationFailedEventHandler NavigationFailed;
		event NavigationStoppedEventHandler NavigationStopped;
		int BackStackDepth
		{
			get;
		}
		int CacheSize
		{
			get;
			set;
		}
		bool CanGoBack
		{
			get;
		}
		bool CanGoForward
		{
			get;
		}
		TypeName CurrentSourcePageType
		{
			get;
		}
		TypeName SourcePageType
		{
			get;
			set;
		}
		void GoBack();
		void GoForward();
		bool Navigate([In] TypeName sourcePageType, [In] object parameter);
		string GetNavigationState();
		void SetNavigationState([In] string navigationState);
	}
}
