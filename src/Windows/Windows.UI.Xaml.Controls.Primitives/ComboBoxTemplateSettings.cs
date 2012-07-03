using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ComboBoxTemplateSettings : DependencyObject, IComboBoxTemplateSettings
	{
		public extern double DropDownClosedHeight
		{
			get;
		}
		public extern double DropDownOffset
		{
			get;
		}
		public extern double DropDownOpenedHeight
		{
			get;
		}
		public extern AnimationDirection SelectedItemDirection
		{
			get;
		}
	}
}
