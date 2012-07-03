using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(SystemCondition)), Guid(3530150385u, 1447, 18862, 135, 215, 22, 178, 184, 185, 165, 83), Version(100794368u)]
	internal interface ISystemConditionFactory
	{
		SystemCondition Create([In] SystemConditionType conditionType);
	}
}
