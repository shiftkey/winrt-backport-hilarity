using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(VisualStateChangedEventArgs)), Guid(4263602865u, 62239, 18321, 137, 137, 199, 14, 29, 155, 89, 255), Version(100794368u), WebHostHidden]
	internal interface IVisualStateChangedEventArgs
	{
		Control Control
		{
			get;
			set;
		}
		VisualState NewState
		{
			get;
			set;
		}
		VisualState OldState
		{
			get;
			set;
		}
	}
}
