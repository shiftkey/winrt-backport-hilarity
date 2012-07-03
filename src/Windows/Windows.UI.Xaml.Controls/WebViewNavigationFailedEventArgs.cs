using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;
namespace Windows.UI.Xaml.Controls
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class WebViewNavigationFailedEventArgs : IWebViewNavigationFailedEventArgs
	{
		public extern Uri Uri
		{
			get;
		}
		public extern WebErrorStatus WebErrorStatus
		{
			get;
		}
	}
}
