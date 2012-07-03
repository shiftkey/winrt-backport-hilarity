using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(VisualStateManager)), Guid(30468576u, 55059, 16718, 167, 78, 230, 62, 199, 172, 140, 61), Version(100794368u), WebHostHidden]
	internal interface IVisualStateManagerStatics
	{
		DependencyProperty CustomVisualStateManagerProperty
		{
			get;
		}
		IVector<VisualStateGroup> GetVisualStateGroups([In] FrameworkElement obj);
		VisualStateManager GetCustomVisualStateManager([In] FrameworkElement obj);
		void SetCustomVisualStateManager([In] FrameworkElement obj, [In] VisualStateManager value);
		bool GoToState([In] Control control, [In] string stateName, [In] bool useTransitions);
	}
}
