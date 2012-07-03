using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(DependencyObject)), Guid(2583932818u, 32138, 18743, 136, 79, 236, 243, 79, 224, 42, 203), Version(100794368u), WebHostHidden]
	internal interface IDependencyObjectFactory
	{
		DependencyObject CreateInstance([In] object outer, out object inner);
	}
}
