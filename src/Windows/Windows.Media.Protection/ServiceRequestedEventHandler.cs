using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[Guid(3537277114u, 51913, 18657, 149, 192, 211, 132, 149, 168, 64, 85), Version(100794368u)]
	public delegate void ServiceRequestedEventHandler([In] MediaProtectionManager sender, [In] ServiceRequestedEventArgs e);
}
