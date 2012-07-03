using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u), WebHostHidden]
	public sealed class AutomationProviderRequestedEventArgs : IAutomationProviderRequestedEventArgs, ICoreWindowEventArgs
	{
		public extern object AutomationProvider
		{
			get;
			set;
		}
		public extern bool Handled
		{
			get;
			set;
		}
	}
}
