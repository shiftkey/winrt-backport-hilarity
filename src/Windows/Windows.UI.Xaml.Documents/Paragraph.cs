using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Documents
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Inlines")]
	public sealed class Paragraph : Block, IParagraph
	{
		public extern InlineCollection Inlines
		{
			get;
		}
		public extern Paragraph();
	}
}
