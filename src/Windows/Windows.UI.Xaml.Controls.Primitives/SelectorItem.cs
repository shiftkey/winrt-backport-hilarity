using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Composable(typeof(ISelectorItemFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISelectorItemStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class SelectorItem : ContentControl, ISelectorItem
	{
		public extern bool IsSelected
		{
			get;
			set;
		}
		public static extern DependencyProperty IsSelectedProperty
		{
			get;
		}
		protected extern SelectorItem();
	}
}
