using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(WebViewNavigationFailedEventArgs)), Guid(2936627354u, 4764, 16752, 158, 156, 226, 205, 240, 37, 220, 164), Version(100794368u), WebHostHidden]
	internal interface IWebViewNavigationFailedEventArgs
	{
		Uri Uri
		{
			get;
		}
		WebErrorStatus WebErrorStatus
		{
			get;
		}
	}
}
