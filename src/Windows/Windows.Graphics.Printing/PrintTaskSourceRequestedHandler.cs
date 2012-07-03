using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[Guid(1813028776u, 23734, 19258, 134, 99, 243, 156, 176, 45, 201, 180), Version(100794368u)]
	public delegate void PrintTaskSourceRequestedHandler([In] PrintTaskSourceRequestedArgs args);
}
