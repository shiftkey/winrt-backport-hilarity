using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(927724929u, 30486, 19388, 130, 235, 217, 151, 0, 110, 169, 153), Version(100794368u), WebHostHidden]
	public interface IScrollProvider
	{
		double HorizontalScrollPercent
		{
			get;
		}
		double HorizontalViewSize
		{
			get;
		}
		bool HorizontallyScrollable
		{
			get;
		}
		double VerticalScrollPercent
		{
			get;
		}
		double VerticalViewSize
		{
			get;
		}
		bool VerticallyScrollable
		{
			get;
		}
		void Scroll([In] ScrollAmount horizontalAmount, [In] ScrollAmount verticalAmount);
		void SetScrollPercent([In] double horizontalPercent, [In] double verticalPercent);
	}
}
