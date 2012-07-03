using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IRadioButtonFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRadioButtonStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class RadioButton : ToggleButton, IRadioButton
	{
		public extern string GroupName
		{
			get;
			set;
		}
		public static extern DependencyProperty GroupNameProperty
		{
			get;
		}
		public extern RadioButton();
	}
}
