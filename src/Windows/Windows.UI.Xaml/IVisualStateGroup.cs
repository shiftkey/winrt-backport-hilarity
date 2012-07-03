using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(VisualStateGroup)), Guid(3841579428u, 57384, 17630, 155, 21, 73, 41, 174, 10, 38, 194), Version(100794368u), WebHostHidden]
	internal interface IVisualStateGroup
	{
		event VisualStateChangedEventHandler CurrentStateChanged;
		event VisualStateChangedEventHandler CurrentStateChanging;
		VisualState CurrentState
		{
			get;
		}
		string Name
		{
			get;
		}
		IVector<VisualState> States
		{
			get;
		}
		IVector<VisualTransition> Transitions
		{
			get;
		}
	}
}
