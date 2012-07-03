using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(DependencyProperty)), Guid(2242984304u, 39876, 20118, 172, 241, 48, 200, 253, 61, 85, 200), Version(100794368u), WebHostHidden]
	internal interface IDependencyProperty
	{
		PropertyMetadata GetMetadata([In] TypeName forType);
	}
}
