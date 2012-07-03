using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(StyleSelector)), Guid(3507568487u, 55489, 19172, 152, 240, 216, 80, 69, 2, 240, 139), Version(100794368u), WebHostHidden]
	internal interface IStyleSelector
	{
		Style SelectStyle([In] object item, [In] DependencyObject container);
	}
}
