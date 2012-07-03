using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ContentControl)), Guid(1598819088u, 58254, 19293, 190, 26, 94, 208, 66, 70, 166, 53), Version(100794368u), WebHostHidden]
	internal interface IContentControlOverrides
	{
		void OnContentChanged([In] object oldContent, [In] object newContent);
		void OnContentTemplateChanged([In] DataTemplate oldContentTemplate, [In] DataTemplate newContentTemplate);
		void OnContentTemplateSelectorChanged([In] DataTemplateSelector oldContentTemplateSelector, [In] DataTemplateSelector newContentTemplateSelector);
	}
}
