using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(WebView)), Guid(2696241630u, 24539, 17467, 185, 240, 92, 48, 246, 183, 161, 244), Version(100794368u), WebHostHidden]
	internal interface IWebViewStatics
	{
		DependencyProperty AllowedScriptNotifyUrisProperty
		{
			get;
		}
		IVector<Uri> AnyScriptNotifyUri
		{
			get;
		}
		DependencyProperty DataTransferPackageProperty
		{
			get;
		}
		DependencyProperty SourceProperty
		{
			get;
		}
	}
}
