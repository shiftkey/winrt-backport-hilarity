using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IStyleSelectorFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class StyleSelector : IStyleSelector, IStyleSelectorOverrides
	{
		public extern StyleSelector();
		public extern Style SelectStyle([In] object item, [In] DependencyObject container);
		protected virtual extern Style SelectStyleCore([In] object item, [In] DependencyObject container);
	}
}
