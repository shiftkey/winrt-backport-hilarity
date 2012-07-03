using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(TimeTrigger)), Guid(1701729622u, 2858, 17271, 186, 112, 59, 69, 169, 53, 84, 127), Version(100794368u)]
	internal interface ITimeTrigger : IBackgroundTrigger
	{
		uint FreshnessTime
		{
			get;
		}
		bool OneShot
		{
			get;
		}
	}
}
