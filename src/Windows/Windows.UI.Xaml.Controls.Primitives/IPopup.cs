using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(Popup)), Guid(1648460352u, 59091, 18181, 161, 220, 57, 21, 100, 86, 238, 41), Version(100794368u), WebHostHidden]
	internal interface IPopup
	{
		event EventHandler<object> Closed;
		event EventHandler<object> Opened;
		UIElement Child
		{
			get;
			set;
		}
		TransitionCollection ChildTransitions
		{
			get;
			set;
		}
		double HorizontalOffset
		{
			get;
			set;
		}
		bool IsLightDismissEnabled
		{
			get;
			set;
		}
		bool IsOpen
		{
			get;
			set;
		}
		double VerticalOffset
		{
			get;
			set;
		}
	}
}
