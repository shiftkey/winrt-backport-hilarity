using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ComboBoxTemplateSettings)), Guid(2200460366u, 6134, 19107, 182, 27, 232, 124, 113, 134, 4, 234), Version(100794368u), WebHostHidden]
	internal interface IComboBoxTemplateSettings
	{
		double DropDownClosedHeight
		{
			get;
		}
		double DropDownOffset
		{
			get;
		}
		double DropDownOpenedHeight
		{
			get;
		}
		AnimationDirection SelectedItemDirection
		{
			get;
		}
	}
}
