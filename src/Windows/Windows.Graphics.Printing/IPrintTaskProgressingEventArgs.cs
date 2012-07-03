using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[ExclusiveTo(typeof(PrintTaskProgressingEventArgs)), Guid(2165101515u, 46096, 17026, 160, 115, 90, 195, 120, 35, 65, 116), Version(100794368u)]
	internal interface IPrintTaskProgressingEventArgs
	{
		uint DocumentPageCount
		{
			get;
		}
	}
}
