using System;
using Windows.Foundation.Metadata;
namespace Windows.System.RemoteDesktop
{
	[MarshalingBehavior(MarshalingType.Standard), Static(typeof(IInteractiveSessionStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class InteractiveSession
	{
		public static extern bool IsRemote
		{
			get;
		}
	}
}
