using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[Composable(typeof(IInlineFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Inline : TextElement, IInline
	{
		protected extern Inline();
	}
}
