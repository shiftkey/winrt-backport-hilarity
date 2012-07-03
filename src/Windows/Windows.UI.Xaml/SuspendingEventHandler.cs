using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Guid(591565925u, 58218, 16610, 177, 57, 164, 112, 70, 2, 166, 225), Version(100794368u), WebHostHidden]
	public delegate void SuspendingEventHandler([In] object sender, [In] SuspendingEventArgs e);
}
