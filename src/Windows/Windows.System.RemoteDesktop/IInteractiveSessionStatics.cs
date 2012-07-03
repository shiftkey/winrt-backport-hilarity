using System;
using Windows.Foundation.Metadata;
namespace Windows.System.RemoteDesktop
{
	[ExclusiveTo(typeof(InteractiveSession)), Guid(1619543601u, 56634, 17782, 156, 141, 232, 2, 118, 24, 189, 206), Version(100794368u)]
	internal interface IInteractiveSessionStatics
	{
		bool IsRemote
		{
			get;
		}
	}
}
