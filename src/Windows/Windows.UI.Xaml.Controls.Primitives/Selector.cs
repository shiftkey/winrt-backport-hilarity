using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Composable(typeof(ISelectorFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISelectorStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Selector : ItemsControl, ISelector
	{
		public extern event SelectionChangedEventHandler SelectionChanged
		{
			add;
			remove;
		}
		public extern IReference<bool> IsSynchronizedWithCurrentItem
		{
			get;
			set;
		}
		public extern int SelectedIndex
		{
			get;
			set;
		}
		public extern object SelectedItem
		{
			get;
			set;
		}
		public extern object SelectedValue
		{
			get;
			set;
		}
		public extern string SelectedValuePath
		{
			get;
			set;
		}
		public static extern DependencyProperty IsSynchronizedWithCurrentItemProperty
		{
			get;
		}
		public static extern DependencyProperty SelectedIndexProperty
		{
			get;
		}
		public static extern DependencyProperty SelectedItemProperty
		{
			get;
		}
		public static extern DependencyProperty SelectedValuePathProperty
		{
			get;
		}
		public static extern DependencyProperty SelectedValueProperty
		{
			get;
		}
		public static extern bool GetIsSelectionActive([In] DependencyObject element);
	}
}
