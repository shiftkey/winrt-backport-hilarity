using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Activatable(typeof(ISystemConditionFactory), 100794368u), MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class SystemCondition : ISystemCondition, IBackgroundCondition
	{
		public extern SystemConditionType ConditionType
		{
			get;
		}
		public extern SystemCondition([In] SystemConditionType conditionType);
	}
}
