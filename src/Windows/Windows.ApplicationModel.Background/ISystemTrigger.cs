using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(SystemTrigger)), Guid(494978934u, 14152, 17507, 141, 126, 39, 109, 193, 57, 172, 28), Version(100794368u)]
	internal interface ISystemTrigger : IBackgroundTrigger
	{
		bool OneShot
		{
			get;
		}
		SystemTriggerType TriggerType
		{
			get;
		}
	}
}
