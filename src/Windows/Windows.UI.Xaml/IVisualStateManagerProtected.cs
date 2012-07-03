using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(VisualStateManager)), Guid(1262192192u, 45239, 16460, 158, 244, 217, 73, 100, 14, 36, 93), Version(100794368u), WebHostHidden]
	internal interface IVisualStateManagerProtected
	{
		void RaiseCurrentStateChanging([In] VisualStateGroup stateGroup, [In] VisualState oldState, [In] VisualState newState, [In] Control control);
		void RaiseCurrentStateChanged([In] VisualStateGroup stateGroup, [In] VisualState oldState, [In] VisualState newState, [In] Control control);
	}
}
