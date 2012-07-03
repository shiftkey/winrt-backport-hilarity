using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ButtonBase)), Guid(1743722465u, 65079, 18255, 158, 151, 59, 94, 11, 48, 242, 223), Version(100794368u), WebHostHidden]
	internal interface IButtonBaseStatics
	{
		DependencyProperty ClickModeProperty
		{
			get;
		}
		DependencyProperty CommandParameterProperty
		{
			get;
		}
		DependencyProperty CommandProperty
		{
			get;
		}
		DependencyProperty IsPointerOverProperty
		{
			get;
		}
		DependencyProperty IsPressedProperty
		{
			get;
		}
	}
}
