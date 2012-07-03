using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Composable(typeof(IButtonBaseFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IButtonBaseStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ButtonBase : ContentControl, IButtonBase
	{
		public extern event RoutedEventHandler Click
		{
			add;
			remove;
		}
		public extern ClickMode ClickMode
		{
			get;
			set;
		}
		public extern ICommand Command
		{
			get;
			set;
		}
		public extern object CommandParameter
		{
			get;
			set;
		}
		public extern bool IsPointerOver
		{
			get;
		}
		public extern bool IsPressed
		{
			get;
		}
		public static extern DependencyProperty ClickModeProperty
		{
			get;
		}
		public static extern DependencyProperty CommandParameterProperty
		{
			get;
		}
		public static extern DependencyProperty CommandProperty
		{
			get;
		}
		public static extern DependencyProperty IsPointerOverProperty
		{
			get;
		}
		public static extern DependencyProperty IsPressedProperty
		{
			get;
		}
		protected extern ButtonBase();
	}
}
