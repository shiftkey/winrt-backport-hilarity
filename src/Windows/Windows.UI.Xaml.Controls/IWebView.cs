using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Navigation;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(WebView)), Guid(1482869830u, 8061, 18331, 146, 166, 222, 120, 88, 254, 141, 84), Version(100794368u), WebHostHidden]
	internal interface IWebView
	{
		event LoadCompletedEventHandler LoadCompleted;
		event WebViewNavigationFailedEventHandler NavigationFailed;
		event NotifyEventHandler ScriptNotify;
		IVector<Uri> AllowedScriptNotifyUris
		{
			get;
			set;
		}
		DataPackage DataTransferPackage
		{
			get;
		}
		Uri Source
		{
			get;
			set;
		}
		string InvokeScript([In] string scriptName, [In] string[] arguments);
		void Navigate([In] Uri source);
		void NavigateToString([In] string text);
	}
}
