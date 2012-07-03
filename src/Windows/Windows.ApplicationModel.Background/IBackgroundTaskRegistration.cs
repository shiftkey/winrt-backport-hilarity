using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Guid(275074242u, 41582, 17343, 140, 18, 31, 180, 13, 191, 191, 160), Version(100794368u)]
	public interface IBackgroundTaskRegistration
	{
		event BackgroundTaskCompletedEventHandler Completed;
		event BackgroundTaskProgressEventHandler Progress;
		string Name
		{
			get;
		}
		Guid TaskId
		{
			get;
		}
		void Unregister([In] bool cancelTask);
	}
}
