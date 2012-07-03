using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u), WebHostHidden]
	public sealed class IdleDispatchedHandlerArgs : IIdleDispatchedHandlerArgs
	{
		public extern bool IsDispatcherIdle
		{
			get;
		}
	}
}
