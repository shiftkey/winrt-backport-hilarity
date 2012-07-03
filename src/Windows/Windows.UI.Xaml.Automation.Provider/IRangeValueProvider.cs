using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(2206872744u, 32095, 16505, 175, 3, 195, 208, 21, 233, 52, 19), Version(100794368u), WebHostHidden]
	public interface IRangeValueProvider
	{
		bool IsReadOnly
		{
			get;
		}
		double LargeChange
		{
			get;
		}
		double Maximum
		{
			get;
		}
		double Minimum
		{
			get;
		}
		double SmallChange
		{
			get;
		}
		double Value
		{
			get;
		}
		void SetValue([In] double value);
	}
}
