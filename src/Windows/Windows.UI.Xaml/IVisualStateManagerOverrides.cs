using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(VisualStateManager)), Guid(1248235790u, 31097, 17352, 143, 244, 236, 97, 34, 117, 0, 6), Version(100794368u), WebHostHidden]
	internal interface IVisualStateManagerOverrides
	{
		bool GoToStateCore([In] Control control, [In] FrameworkElement templateRoot, [In] string stateName, [In] VisualStateGroup group, [In] VisualState state, [In] bool useTransitions);
	}
}
