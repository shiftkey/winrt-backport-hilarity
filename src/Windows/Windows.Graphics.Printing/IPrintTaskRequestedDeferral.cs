using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[ExclusiveTo(typeof(PrintTaskRequestedDeferral)), Guid(3488592880u, 52798, 17095, 148, 150, 100, 128, 12, 98, 44, 68), Version(100794368u)]
	internal interface IPrintTaskRequestedDeferral
	{
		void Complete();
	}
}
