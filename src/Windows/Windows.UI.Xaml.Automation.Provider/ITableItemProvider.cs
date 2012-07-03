using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(992758221u, 7650, 20194, 163, 225, 251, 85, 53, 89, 209, 93), Version(100794368u), WebHostHidden]
	public interface ITableItemProvider
	{
		IRawElementProviderSimple[] GetColumnHeaderItems();
		IRawElementProviderSimple[] GetRowHeaderItems();
	}
}
