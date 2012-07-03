using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Composable(typeof(IToggleButtonFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IToggleButtonStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ToggleButton : ButtonBase, IToggleButton, IToggleButtonOverrides
	{
		public extern event RoutedEventHandler Checked
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler Indeterminate
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler Unchecked
		{
			add;
			remove;
		}
		public extern IReference<bool> IsChecked
		{
			get;
			set;
		}
		public extern bool IsThreeState
		{
			get;
			set;
		}
		public static extern DependencyProperty IsCheckedProperty
		{
			get;
		}
		public static extern DependencyProperty IsThreeStateProperty
		{
			get;
		}
		public extern ToggleButton();
		protected virtual extern void OnToggle();
	}
}
