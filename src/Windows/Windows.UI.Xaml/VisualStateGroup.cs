using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "States")]
	public sealed class VisualStateGroup : DependencyObject, IVisualStateGroup
	{
		public extern event VisualStateChangedEventHandler CurrentStateChanged
		{
			add;
			remove;
		}
		public extern event VisualStateChangedEventHandler CurrentStateChanging
		{
			add;
			remove;
		}
		public extern VisualState CurrentState
		{
			get;
		}
		public extern string Name
		{
			get;
		}
		public extern IVector<VisualState> States
		{
			get;
		}
		public extern IVector<VisualTransition> Transitions
		{
			get;
		}
		public extern VisualStateGroup();
	}
}
