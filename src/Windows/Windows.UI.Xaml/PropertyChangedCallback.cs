using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Guid(1520405029u, 53570, 17572, 130, 49, 253, 103, 103, 36, 242, 155), Version(100794368u), WebHostHidden]
	public delegate void PropertyChangedCallback([In] DependencyObject d, [In] DependencyPropertyChangedEventArgs e);
}
