using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[Guid(467383412u, 20177, 16875, 190, 60, 114, 209, 142, 214, 115, 55), Version(100794368u)]
	public interface IPrintTaskOptionsCore
	{
		PrintPageDescription GetPageDescription([In] uint jobPageNumber);
	}
}
