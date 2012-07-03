using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ContentPresenter)), Guid(2808297965u, 13055, 17291, 170, 213, 29, 104, 250, 233, 52, 38), Version(100794368u), WebHostHidden]
	internal interface IContentPresenterOverrides
	{
		void OnContentTemplateChanged([In] DataTemplate oldContentTemplate, [In] DataTemplate newContentTemplate);
		void OnContentTemplateSelectorChanged([In] DataTemplateSelector oldContentTemplateSelector, [In] DataTemplateSelector newContentTemplateSelector);
	}
}
