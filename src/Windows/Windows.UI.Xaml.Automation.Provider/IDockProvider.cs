using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(1220690936u, 30897, 17568, 172, 95, 117, 7, 87, 188, 222, 60), Version(100794368u), WebHostHidden]
	public interface IDockProvider
	{
		DockPosition DockPosition
		{
			get;
		}
		void SetDockPosition([In] DockPosition dockPosition);
	}
}
