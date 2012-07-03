using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(DataTemplateSelector)), Guid(756427045u, 22886, 19450, 134, 56, 77, 52, 86, 137, 246, 207), Version(100794368u), WebHostHidden]
	internal interface IDataTemplateSelectorOverrides
	{
		DataTemplate SelectTemplateCore([In] object item, [In] DependencyObject container);
	}
}
