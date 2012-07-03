using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(StyleSelector)), Guid(145610349u, 3630, 17312, 174, 202, 143, 170, 148, 185, 208, 23), Version(100794368u), WebHostHidden]
	internal interface IStyleSelectorOverrides
	{
		Style SelectStyleCore([In] object item, [In] DependencyObject container);
	}
}
