using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(WebViewBrush)), Guid(1088974709u, 3316, 19314, 164, 214, 207, 93, 21, 120, 1, 22), Version(100794368u), WebHostHidden]
	internal interface IWebViewBrush
	{
		string SourceName
		{
			get;
			set;
		}
		void Redraw();
		void SetSource([In] WebView source);
	}
}
