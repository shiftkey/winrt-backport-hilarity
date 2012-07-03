using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Control)), Guid(2828083811u, 10577, 20312, 169, 197, 90, 19, 78, 170, 127, 7), Version(100794368u), WebHostHidden]
	internal interface IControl
	{
		event DependencyPropertyChangedEventHandler IsEnabledChanged;
		Brush Background
		{
			get;
			set;
		}
		Brush BorderBrush
		{
			get;
			set;
		}
		Thickness BorderThickness
		{
			get;
			set;
		}
		int CharacterSpacing
		{
			get;
			set;
		}
		FocusState FocusState
		{
			get;
		}
		FontFamily FontFamily
		{
			get;
			set;
		}
		double FontSize
		{
			get;
			set;
		}
		FontStretch FontStretch
		{
			get;
			set;
		}
		FontStyle FontStyle
		{
			get;
			set;
		}
		FontWeight FontWeight
		{
			get;
			set;
		}
		Brush Foreground
		{
			get;
			set;
		}
		HorizontalAlignment HorizontalContentAlignment
		{
			get;
			set;
		}
		bool IsEnabled
		{
			get;
			set;
		}
		bool IsTabStop
		{
			get;
			set;
		}
		Thickness Padding
		{
			get;
			set;
		}
		int TabIndex
		{
			get;
			set;
		}
		KeyboardNavigationMode TabNavigation
		{
			get;
			set;
		}
		ControlTemplate Template
		{
			get;
			set;
		}
		VerticalAlignment VerticalContentAlignment
		{
			get;
			set;
		}
		bool ApplyTemplate();
		bool Focus([In] FocusState value);
	}
}
