using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Documents
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Child")]
	public sealed class InlineUIContainer : Inline, IInlineUIContainer
	{
		public extern UIElement Child
		{
			get;
			set;
		}
		public extern InlineUIContainer();
	}
}
