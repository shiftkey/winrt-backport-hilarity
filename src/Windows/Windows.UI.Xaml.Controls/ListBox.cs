using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IListBoxFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IListBoxStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ListBox : Selector, IListBox
	{
		public extern IVector<object> SelectedItems
		{
			get;
		}
		public extern SelectionMode SelectionMode
		{
			get;
			set;
		}
		public static extern DependencyProperty SelectionModeProperty
		{
			get;
		}
		public extern ListBox();
		public extern void ScrollIntoView([In] object item);
		public extern void SelectAll();
	}
}
