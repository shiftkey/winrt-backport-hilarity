using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(779585193u, 32764, 20311, 185, 101, 30, 241, 243, 115, 245, 70), Version(100794368u), WebHostHidden]
	public interface IDragProvider
	{
		string DropEffect
		{
			get;
		}
		string[] DropEffects
		{
			get;
		}
		bool IsGrabbed
		{
			get;
		}
		IRawElementProviderSimple[] GetGrabbedItems();
	}
}
