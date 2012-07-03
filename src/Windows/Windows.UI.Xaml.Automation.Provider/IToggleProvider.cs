using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(2478342800u, 25967, 17655, 174, 175, 120, 184, 249, 68, 208, 98), Version(100794368u), WebHostHidden]
	public interface IToggleProvider
	{
		ToggleState ToggleState
		{
			get;
		}
		void Toggle();
	}
}
