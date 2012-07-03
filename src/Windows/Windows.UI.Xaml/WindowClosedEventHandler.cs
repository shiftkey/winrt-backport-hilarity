using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
namespace Windows.UI.Xaml
{
	[Guid(230199649u, 8407, 17887, 145, 34, 186, 137, 87, 103, 3, 186), Version(100794368u), WebHostHidden]
	public delegate void WindowClosedEventHandler([In] object sender, [In] CoreWindowEventArgs e);
}
