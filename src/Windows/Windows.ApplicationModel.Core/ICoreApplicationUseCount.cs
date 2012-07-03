using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Core
{
	[ExclusiveTo(typeof(CoreApplication)), Guid(1368245256u, 49271, 18267, 128, 158, 11, 192, 197, 126, 75, 116), Version(100794368u), WebHostHidden]
	internal interface ICoreApplicationUseCount
	{
		void IncrementApplicationUseCount();
		void DecrementApplicationUseCount();
	}
}
