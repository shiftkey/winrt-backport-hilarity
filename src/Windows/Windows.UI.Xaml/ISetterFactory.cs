using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(Setter)), Guid(3553246530u, 2481, 18901, 136, 145, 231, 181, 100, 142, 2, 162), Version(100794368u), WebHostHidden]
	internal interface ISetterFactory
	{
		Setter CreateInstance([In] DependencyProperty targetProperty, [In] object value);
	}
}
