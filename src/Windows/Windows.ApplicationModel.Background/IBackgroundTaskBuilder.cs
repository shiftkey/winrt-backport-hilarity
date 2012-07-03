using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(BackgroundTaskBuilder)), Guid(55661838u, 15972, 17778, 169, 58, 132, 7, 90, 55, 201, 23), Version(100794368u)]
	internal interface IBackgroundTaskBuilder
	{
		string Name
		{
			get;
			set;
		}
		string TaskEntryPoint
		{
			get;
			set;
		}
		void SetTrigger([In] IBackgroundTrigger trigger);
		void AddCondition([In] IBackgroundCondition condition);
		BackgroundTaskRegistration Register();
	}
}
