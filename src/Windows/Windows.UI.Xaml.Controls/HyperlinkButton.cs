using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IHyperlinkButtonFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IHyperlinkButtonStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class HyperlinkButton : ButtonBase, IHyperlinkButton
	{
		public extern Uri NavigateUri
		{
			get;
			set;
		}
		public static extern DependencyProperty NavigateUriProperty
		{
			get;
		}
		public extern HyperlinkButton();
	}
}
