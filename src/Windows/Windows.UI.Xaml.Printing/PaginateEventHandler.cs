using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Printing
{
	[Guid(213932897u, 33051, 18994, 153, 101, 19, 235, 120, 219, 176, 27), Version(100794368u), WebHostHidden]
	public delegate void PaginateEventHandler([In] object sender, [In] PaginateEventArgs e);
}
