using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[ExclusiveTo(typeof(PropertyChangedEventArgs)), Guid(1842125827u, 57543, 20206, 142, 169, 55, 227, 64, 110, 235, 28), Version(100794368u), WebHostHidden]
	internal interface IPropertyChangedEventArgsFactory
	{
		PropertyChangedEventArgs CreateInstance([In] string name, [In] object outer, out object inner);
	}
}
