using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml
{
	[Composable(typeof(IVisualStateManagerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IVisualStateManagerStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class VisualStateManager : DependencyObject, IVisualStateManager, IVisualStateManagerOverrides, IVisualStateManagerProtected
	{
		public static extern DependencyProperty CustomVisualStateManagerProperty
		{
			get;
		}
		public extern VisualStateManager();
		protected virtual extern bool GoToStateCore([In] Control control, [In] FrameworkElement templateRoot, [In] string stateName, [In] VisualStateGroup group, [In] VisualState state, [In] bool useTransitions);
		protected extern void RaiseCurrentStateChanging([In] VisualStateGroup stateGroup, [In] VisualState oldState, [In] VisualState newState, [In] Control control);
		protected extern void RaiseCurrentStateChanged([In] VisualStateGroup stateGroup, [In] VisualState oldState, [In] VisualState newState, [In] Control control);
		public static extern IVector<VisualStateGroup> GetVisualStateGroups([In] FrameworkElement obj);
		public static extern VisualStateManager GetCustomVisualStateManager([In] FrameworkElement obj);
		public static extern void SetCustomVisualStateManager([In] FrameworkElement obj, [In] VisualStateManager value);
		public static extern bool GoToState([In] Control control, [In] string stateName, [In] bool useTransitions);
	}
}
