using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ItemsControl)), Guid(3348870171u, 41092, 17153, 164, 150, 114, 151, 31, 54, 78, 209), Version(100794368u), WebHostHidden]
	internal interface IItemsControlOverrides
	{
		bool IsItemItsOwnContainerOverride([In] object item);
		DependencyObject GetContainerForItemOverride();
		void ClearContainerForItemOverride([In] DependencyObject element, [In] object item);
		void PrepareContainerForItemOverride([In] DependencyObject element, [In] object item);
		void OnItemsChanged([In] object e);
		void OnItemContainerStyleChanged([In] Style oldItemContainerStyle, [In] Style newItemContainerStyle);
		void OnItemContainerStyleSelectorChanged([In] StyleSelector oldItemContainerStyleSelector, [In] StyleSelector newItemContainerStyleSelector);
		void OnItemTemplateChanged([In] DataTemplate oldItemTemplate, [In] DataTemplate newItemTemplate);
		void OnItemTemplateSelectorChanged([In] DataTemplateSelector oldItemTemplateSelector, [In] DataTemplateSelector newItemTemplateSelector);
		void OnGroupStyleSelectorChanged([In] GroupStyleSelector oldGroupStyleSelector, [In] GroupStyleSelector newGroupStyleSelector);
	}
}
