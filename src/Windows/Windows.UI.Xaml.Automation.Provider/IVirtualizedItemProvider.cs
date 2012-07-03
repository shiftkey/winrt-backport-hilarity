using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(399810635u, 54872, 18656, 165, 116, 90, 81, 108, 88, 223, 167), Version(100794368u), WebHostHidden]
	public interface IVirtualizedItemProvider
	{
		void Realize();
	}
}
