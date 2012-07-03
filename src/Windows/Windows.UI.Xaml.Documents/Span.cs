using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Documents
{
	[Composable(typeof(ISpanFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Inlines")]
	public class Span : Inline, ISpan
	{
		public extern InlineCollection Inlines
		{
			get;
			set;
		}
		public extern Span();
	}
}
