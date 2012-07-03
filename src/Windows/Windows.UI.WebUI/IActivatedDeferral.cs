using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[ExclusiveTo(typeof(ActivatedDeferral)), Guid(3283949944u, 42033, 18904, 167, 106, 57, 90, 78, 3, 220, 243), Version(100794368u)]
	internal interface IActivatedDeferral
	{
		void Complete();
	}
}
