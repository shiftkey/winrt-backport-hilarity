using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IListViewFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ListView : ListViewBase, IListView
	{
		public extern ListView();
	}
}
