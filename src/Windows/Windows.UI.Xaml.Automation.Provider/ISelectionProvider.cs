using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(520196042u, 47428, 17301, 141, 225, 136, 246, 116, 175, 81, 211), Version(100794368u), WebHostHidden]
	public interface ISelectionProvider
	{
		bool CanSelectMultiple
		{
			get;
		}
		bool IsSelectionRequired
		{
			get;
		}
		IRawElementProviderSimple[] GetSelection();
	}
}
