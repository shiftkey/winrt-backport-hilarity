using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(1783199681u, 33549, 17106, 191, 98, 4, 46, 189, 222, 204, 25), Version(100794368u), WebHostHidden]
	public interface ISelectionItemProvider
	{
		bool IsSelected
		{
			get;
		}
		IRawElementProviderSimple SelectionContainer
		{
			get;
		}
		void AddToSelection();
		void RemoveFromSelection();
		void Select();
	}
}
