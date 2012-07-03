using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(4015839301u, 57812, 16628, 186, 213, 199, 250, 212, 74, 112, 62), Version(100794368u), WebHostHidden]
	public interface IItemContainerProvider
	{
		IRawElementProviderSimple FindItemByProperty([In] IRawElementProviderSimple startAfter, [In] AutomationProperty automationProperty, [In] object value);
	}
}
