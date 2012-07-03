using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[ExclusiveTo(typeof(PrintTaskSourceRequestedDeferral)), Guid(1242915025u, 27026, 19869, 133, 85, 76, 164, 86, 63, 177, 102), Version(100794368u)]
	internal interface IPrintTaskSourceRequestedDeferral
	{
		void Complete();
	}
}
