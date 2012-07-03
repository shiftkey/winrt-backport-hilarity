using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IComboBoxFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IComboBoxStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ComboBox : Selector, IComboBox, IComboBoxOverrides
	{
		public extern event EventHandler<object> DropDownClosed
		{
			add;
			remove;
		}
		public extern event EventHandler<object> DropDownOpened
		{
			add;
			remove;
		}
		public extern bool IsDropDownOpen
		{
			get;
			set;
		}
		public extern bool IsEditable
		{
			get;
		}
		public extern bool IsSelectionBoxHighlighted
		{
			get;
		}
		public extern double MaxDropDownHeight
		{
			get;
			set;
		}
		public extern object SelectionBoxItem
		{
			get;
		}
		public extern DataTemplate SelectionBoxItemTemplate
		{
			get;
		}
		public extern ComboBoxTemplateSettings TemplateSettings
		{
			get;
		}
		public static extern DependencyProperty IsDropDownOpenProperty
		{
			get;
		}
		public static extern DependencyProperty MaxDropDownHeightProperty
		{
			get;
		}
		public extern ComboBox();
		protected virtual extern void OnDropDownClosed([In] object e);
		protected virtual extern void OnDropDownOpened([In] object e);
	}
}
