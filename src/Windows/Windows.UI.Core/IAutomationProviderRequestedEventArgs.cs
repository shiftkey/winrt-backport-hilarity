using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(AutomationProviderRequestedEventArgs)), Guid(2518676056u, 8639, 19266, 162, 152, 250, 71, 157, 76, 82, 226), Version(100794368u), WebHostHidden]
	internal interface IAutomationProviderRequestedEventArgs : ICoreWindowEventArgs
	{
		object AutomationProvider
		{
			get;
			set;
		}
	}
}
