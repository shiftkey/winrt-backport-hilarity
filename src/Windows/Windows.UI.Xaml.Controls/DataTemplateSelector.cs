using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IDataTemplateSelectorFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class DataTemplateSelector : IDataTemplateSelector, IDataTemplateSelectorOverrides
	{
		public extern DataTemplateSelector();
		public extern DataTemplate SelectTemplate([In] object item, [In] DependencyObject container);
		protected virtual extern DataTemplate SelectTemplateCore([In] object item, [In] DependencyObject container);
	}
}
