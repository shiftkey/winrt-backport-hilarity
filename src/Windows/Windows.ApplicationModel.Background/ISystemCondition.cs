using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(SystemCondition)), Guid(3244274806u, 35269, 16907, 171, 211, 251, 48, 48, 71, 33, 40), Version(100794368u)]
	internal interface ISystemCondition : IBackgroundCondition
	{
		SystemConditionType ConditionType
		{
			get;
		}
	}
}
