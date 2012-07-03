using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(Span)), Guid(1536257884u, 52525, 16576, 149, 106, 56, 100, 72, 50, 47, 121), Version(100794368u), WebHostHidden]
	internal interface ISpanFactory
	{
		Span CreateInstance([In] object outer, out object inner);
	}
}
