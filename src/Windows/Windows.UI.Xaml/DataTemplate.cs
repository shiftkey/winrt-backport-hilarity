using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Composable(typeof(IDataTemplateFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class DataTemplate : FrameworkTemplate, IDataTemplate
	{
		public extern DataTemplate();
		public extern DependencyObject LoadContent();
	}
}
