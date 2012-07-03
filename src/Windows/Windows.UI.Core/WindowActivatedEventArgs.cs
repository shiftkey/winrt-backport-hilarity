using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u), WebHostHidden]
	public sealed class WindowActivatedEventArgs : IWindowActivatedEventArgs, ICoreWindowEventArgs
	{
		public extern CoreWindowActivationState WindowActivationState
		{
			get;
		}
		public extern bool Handled
		{
			get;
			set;
		}
	}
}
