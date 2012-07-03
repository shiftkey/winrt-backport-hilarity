using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IListViewItemFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ListViewItem : SelectorItem, IListViewItem
	{
		public extern ListViewItemTemplateSettings TemplateSettings
		{
			get;
		}
		public extern ListViewItem();
	}
}
