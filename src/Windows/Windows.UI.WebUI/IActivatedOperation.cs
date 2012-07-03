using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[ExclusiveTo(typeof(ActivatedOperation)), Guid(3063985340u, 50890, 17149, 152, 24, 113, 144, 78, 69, 254, 215), Version(100794368u)]
	internal interface IActivatedOperation
	{
		ActivatedDeferral GetDeferral();
	}
}
