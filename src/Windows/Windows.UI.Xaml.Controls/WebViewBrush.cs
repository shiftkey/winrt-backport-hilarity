using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IWebViewBrushStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class WebViewBrush : TileBrush, IWebViewBrush
	{
		public extern string SourceName
		{
			get;
			set;
		}
		public static extern DependencyProperty SourceNameProperty
		{
			get;
		}
		public extern WebViewBrush();
		public extern void Redraw();
		public extern void SetSource([In] WebView source);
	}
}
