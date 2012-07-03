using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(DataTemplateSelector)), Guid(2835862678u, 18080, 19671, 141, 190, 249, 165, 129, 223, 96, 177), Version(100794368u), WebHostHidden]
	internal interface IDataTemplateSelector
	{
		DataTemplate SelectTemplate([In] object item, [In] DependencyObject container);
	}
}
