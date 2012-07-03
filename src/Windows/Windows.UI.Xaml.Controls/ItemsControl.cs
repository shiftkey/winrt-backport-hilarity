using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IItemsControlFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IItemsControlStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Items")]
	public class ItemsControl : Control, IItemsControl, IItemsControlOverrides
	{
		public extern string DisplayMemberPath
		{
			get;
			set;
		}
		public extern IObservableVector<GroupStyle> GroupStyle
		{
			get;
		}
		public extern GroupStyleSelector GroupStyleSelector
		{
			get;
			set;
		}
		public extern bool IsGrouping
		{
			get;
		}
		public extern ItemContainerGenerator ItemContainerGenerator
		{
			get;
		}
		public extern Style ItemContainerStyle
		{
			get;
			set;
		}
		public extern StyleSelector ItemContainerStyleSelector
		{
			get;
			set;
		}
		public extern TransitionCollection ItemContainerTransitions
		{
			get;
			set;
		}
		public extern DataTemplate ItemTemplate
		{
			get;
			set;
		}
		public extern DataTemplateSelector ItemTemplateSelector
		{
			get;
			set;
		}
		public extern ItemCollection Items
		{
			get;
		}
		public extern ItemsPanelTemplate ItemsPanel
		{
			get;
			set;
		}
		public extern object ItemsSource
		{
			get;
			set;
		}
		public static extern DependencyProperty DisplayMemberPathProperty
		{
			get;
		}
		public static extern DependencyProperty GroupStyleSelectorProperty
		{
			get;
		}
		public static extern DependencyProperty IsGroupingProperty
		{
			get;
		}
		public static extern DependencyProperty ItemContainerStyleProperty
		{
			get;
		}
		public static extern DependencyProperty ItemContainerStyleSelectorProperty
		{
			get;
		}
		public static extern DependencyProperty ItemContainerTransitionsProperty
		{
			get;
		}
		public static extern DependencyProperty ItemTemplateProperty
		{
			get;
		}
		public static extern DependencyProperty ItemTemplateSelectorProperty
		{
			get;
		}
		public static extern DependencyProperty ItemsPanelProperty
		{
			get;
		}
		public static extern DependencyProperty ItemsSourceProperty
		{
			get;
		}
		public extern ItemsControl();
		protected virtual extern bool IsItemItsOwnContainerOverride([In] object item);
		protected virtual extern DependencyObject GetContainerForItemOverride();
		protected virtual extern void ClearContainerForItemOverride([In] DependencyObject element, [In] object item);
		protected virtual extern void PrepareContainerForItemOverride([In] DependencyObject element, [In] object item);
		protected virtual extern void OnItemsChanged([In] object e);
		protected virtual extern void OnItemContainerStyleChanged([In] Style oldItemContainerStyle, [In] Style newItemContainerStyle);
		protected virtual extern void OnItemContainerStyleSelectorChanged([In] StyleSelector oldItemContainerStyleSelector, [In] StyleSelector newItemContainerStyleSelector);
		protected virtual extern void OnItemTemplateChanged([In] DataTemplate oldItemTemplate, [In] DataTemplate newItemTemplate);
		protected virtual extern void OnItemTemplateSelectorChanged([In] DataTemplateSelector oldItemTemplateSelector, [In] DataTemplateSelector newItemTemplateSelector);
		protected virtual extern void OnGroupStyleSelectorChanged([In] GroupStyleSelector oldGroupStyleSelector, [In] GroupStyleSelector newGroupStyleSelector);
		public static extern ItemsControl GetItemsOwner([In] DependencyObject element);
		public static extern ItemsControl ItemsControlFromItemContainer([In] DependencyObject container);
	}
}
