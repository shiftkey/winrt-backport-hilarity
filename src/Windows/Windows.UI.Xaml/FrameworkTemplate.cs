using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml
{
	[Composable(typeof(IFrameworkTemplateFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Template")]
	public class FrameworkTemplate : DependencyObject, IFrameworkTemplate
	{
		protected extern FrameworkTemplate();
	}
}
