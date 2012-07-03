using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Guid(2098451764u, 64786, 17358, 140, 34, 234, 31, 241, 60, 6, 223), Version(100794368u), WebHostHidden]
	public interface IBackgroundTask
	{
		void Run([In] IBackgroundTaskInstance taskInstance);
	}
}
