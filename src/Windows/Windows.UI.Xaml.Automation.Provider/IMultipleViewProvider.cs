using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(3491029398u, 3664, 18499, 165, 210, 194, 40, 151, 200, 132, 90), Version(100794368u), WebHostHidden]
	public interface IMultipleViewProvider
	{
		int CurrentView
		{
			get;
		}
		int[] GetSupportedViews();
		string GetViewName([In] int viewId);
		void SetCurrentView([In] int viewId);
	}
}
