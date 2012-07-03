using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ButtonBase)), Guid(4194315290u, 18766, 18127, 145, 212, 225, 74, 141, 121, 134, 116), Version(100794368u), WebHostHidden]
	internal interface IButtonBase
	{
		event RoutedEventHandler Click;
		ClickMode ClickMode
		{
			get;
			set;
		}
		ICommand Command
		{
			get;
			set;
		}
		object CommandParameter
		{
			get;
			set;
		}
		bool IsPointerOver
		{
			get;
		}
		bool IsPressed
		{
			get;
		}
	}
}
