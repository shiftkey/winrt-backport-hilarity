using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Navigation;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IWebViewStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class WebView : FrameworkElement, IWebView
	{
		public extern event LoadCompletedEventHandler LoadCompleted
		{
			add;
			remove;
		}
		public extern event WebViewNavigationFailedEventHandler NavigationFailed
		{
			add;
			remove;
		}
		public extern event NotifyEventHandler ScriptNotify
		{
			add;
			remove;
		}
		public extern IVector<Uri> AllowedScriptNotifyUris
		{
			get;
			set;
		}
		public extern DataPackage DataTransferPackage
		{
			get;
		}
		public extern Uri Source
		{
			get;
			set;
		}
		public static extern DependencyProperty AllowedScriptNotifyUrisProperty
		{
			get;
		}
		public static extern IVector<Uri> AnyScriptNotifyUri
		{
			get;
		}
		public static extern DependencyProperty DataTransferPackageProperty
		{
			get;
		}
		public static extern DependencyProperty SourceProperty
		{
			get;
		}
		public extern WebView();
		public extern string InvokeScript([In] string scriptName, [In] string[] arguments);
		public extern void Navigate([In] Uri source);
		public extern void NavigateToString([In] string text);
	}
}
