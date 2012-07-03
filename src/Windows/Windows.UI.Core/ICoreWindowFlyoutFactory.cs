using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(CoreWindowFlyout)), Guid(3737437892u, 37864, 20348, 190, 39, 206, 250, 161, 175, 104, 167), Version(100794368u), WebHostHidden]
	internal interface ICoreWindowFlyoutFactory
	{
		CoreWindowFlyout Create([In] Point position);
		CoreWindowFlyout CreateWithTitle([In] Point position, [In] string title);
	}
}
