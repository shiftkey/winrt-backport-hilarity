using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[Guid(3396165492u, 25538, 17574, 185, 123, 217, 160, 60, 32, 188, 155), Version(100794368u)]
	public interface IActivatedEventArgsDeferral
	{
		ActivatedOperation ActivatedOperation
		{
			get;
		}
	}
}
