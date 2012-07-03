using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(545699751u, 44046, 18385, 171, 155, 42, 100, 41, 42, 253, 248), Version(100794368u), WebHostHidden]
	public interface IValueProvider
	{
		bool IsReadOnly
		{
			get;
		}
		string Value
		{
			get;
		}
		void SetValue([In] string value);
	}
}
