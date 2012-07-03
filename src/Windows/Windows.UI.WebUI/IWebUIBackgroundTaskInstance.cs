using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[Guid(603008037u, 58103, 18241, 188, 156, 57, 69, 149, 222, 36, 220), Version(100794368u)]
	public interface IWebUIBackgroundTaskInstance
	{
		bool Succeeded
		{
			get;
			set;
		}
	}
}
