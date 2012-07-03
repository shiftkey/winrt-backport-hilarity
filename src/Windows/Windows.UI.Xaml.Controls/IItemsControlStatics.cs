using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ItemsControl)), Guid(937082249u, 56571, 17848, 154, 254, 135, 77, 240, 151, 144, 94), Version(100794368u), WebHostHidden]
	internal interface IItemsControlStatics
	{
		DependencyProperty DisplayMemberPathProperty
		{
			get;
		}
		DependencyProperty GroupStyleSelectorProperty
		{
			get;
		}
		DependencyProperty IsGroupingProperty
		{
			get;
		}
		DependencyProperty ItemContainerStyleProperty
		{
			get;
		}
		DependencyProperty ItemContainerStyleSelectorProperty
		{
			get;
		}
		DependencyProperty ItemContainerTransitionsProperty
		{
			get;
		}
		DependencyProperty ItemTemplateProperty
		{
			get;
		}
		DependencyProperty ItemTemplateSelectorProperty
		{
			get;
		}
		DependencyProperty ItemsPanelProperty
		{
			get;
		}
		DependencyProperty ItemsSourceProperty
		{
			get;
		}
		ItemsControl GetItemsOwner([In] DependencyObject element);
		ItemsControl ItemsControlFromItemContainer([In] DependencyObject container);
	}
}
