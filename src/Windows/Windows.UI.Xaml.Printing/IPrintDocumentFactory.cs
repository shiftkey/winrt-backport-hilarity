using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Printing
{
	[ExclusiveTo(typeof(PrintDocument)), Guid(4219974031u, 9734, 18991, 153, 212, 167, 205, 188, 53, 215, 199), Version(100794368u), WebHostHidden]
	internal interface IPrintDocumentFactory
	{
		PrintDocument CreateInstance([In] object outer, out object inner);
	}
}
